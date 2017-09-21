namespace ETWDeserializer
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text.RegularExpressions;
    using CustomParsers;

    public sealed class Deserializer<T>
        where T : IEtwWriter
    {
        private static readonly Type ReaderType = typeof(EventRecordReader);

        private static readonly Type EventMetadataArrayType = typeof(EventMetadata[]);

        private static readonly Type RuntimeMetadataType = typeof(RuntimeEventMetadata);

        private static readonly Regex InvalidCharacters = new Regex("[:\\/*?\"<>|\"-]");

        private static readonly Type WriterType = typeof(T);

        private readonly Dictionary<TraceEventKey, Action<EventRecordReader, T, EventMetadata[], RuntimeEventMetadata>> actionTable = new Dictionary<TraceEventKey, Action<EventRecordReader, T, EventMetadata[], RuntimeEventMetadata>>();

        private readonly Dictionary<Guid, EventSourceManifest> eventSourceManifestCache = new Dictionary<Guid, EventSourceManifest>();

        private readonly List<EventMetadata> eventMetadataTableList = new List<EventMetadata>();

        private readonly T writer;

        private EventMetadata[] eventMetadataTable;

        public Deserializer(T writer)
        {
            this.writer = writer;
        }

        [AllowReversePInvokeCalls]
        public bool BufferCallback(IntPtr logfile)
        {
            return true;
        }

        [AllowReversePInvokeCalls]
        public unsafe void Deserialize(EVENT_RECORD* eventRecord)
        {
            eventRecord->UserDataFixed = eventRecord->UserData;
            var eventRecordReader = new EventRecordReader(eventRecord);
            var runtimeMetadata = new RuntimeEventMetadata(eventRecord);

            var key = new TraceEventKey(
                eventRecord->ProviderId,
                (eventRecord->Flags & Etw.EVENT_HEADER_FLAG_CLASSIC_HEADER) != 0 ? eventRecord->Opcode : eventRecord->Id,
                eventRecord->Version);

            Action<EventRecordReader, T, EventMetadata[], RuntimeEventMetadata> action;
            if (this.actionTable.TryGetValue(key, out action))
            {
                action(eventRecordReader, this.writer, this.eventMetadataTable, runtimeMetadata);
            }
            else
            {
                this.SlowLookup(eventRecord, eventRecordReader, runtimeMetadata, ref key);
            }
        }

        private static unsafe IEventTraceOperand BuildOperandFromXml(EVENT_RECORD* eventRecord, Dictionary<Guid, EventSourceManifest> cache, EventRecordReader eventRecordReader, int metadataTableIndex)
        {
            EventSourceManifest manifest;
            Guid providerGuid = eventRecord->ProviderId;
            if (!cache.TryGetValue(providerGuid, out manifest))
            {
                manifest = CreateEventSourceManifest(providerGuid, cache, eventRecord, eventRecordReader);
            }

            if (manifest == null)
            {
                return null;
            }

            return !manifest.IsComplete ? null : EventTraceOperandBuilder.Build(manifest.Schema, eventRecord->Id, metadataTableIndex);
        }

        private static unsafe IEventTraceOperand BuildOperandFromTdh(EVENT_RECORD* eventRecord, int metadataTableIndex)
        {
            uint bufferSize;
            byte* buffer = (byte*)0;

            // Not Found
            if (Tdh.GetEventInformation(eventRecord, 0, IntPtr.Zero, buffer, out bufferSize) == 1168)
            {
                return null;
            }

            buffer = (byte*)Marshal.AllocHGlobal((int)bufferSize);
            Tdh.GetEventInformation(eventRecord, 0, IntPtr.Zero, buffer, out bufferSize);

            var traceEventInfo = (TRACE_EVENT_INFO*)buffer;
            IEventTraceOperand traceEventOperand = EventTraceOperandBuilder.Build(traceEventInfo, metadataTableIndex);

            Marshal.FreeHGlobal((IntPtr)buffer);

            return traceEventOperand;
        }

        private static unsafe IEventTraceOperand BuildUnknownOperand(EVENT_RECORD* eventRecord, int metadataTableIndex)
        {
            return new UnknownOperandBuilder(eventRecord->ProviderId, metadataTableIndex);
        }

        private static unsafe EventSourceManifest CreateEventSourceManifest(Guid providerGuid, Dictionary<Guid, EventSourceManifest> cache, EVENT_RECORD* eventRecord, EventRecordReader eventRecordReader)
        {
            // EventSource Schema events have the following signature:
            // { byte Format, byte MajorVersion, byte MinorVersion, byte Magic, ushort TotalChunks, ushort ChunkNumber } == 8 bytes, followed by the XML schema
            if (eventRecord->UserDataLength <= 8)
            {
                return null;
            }

            var format = eventRecordReader.ReadUInt8();
            var majorVersion = eventRecordReader.ReadUInt8();
            var minorVersion = eventRecordReader.ReadUInt8();
            var magic = eventRecordReader.ReadUInt8();
            ushort totalChunks = eventRecordReader.ReadUInt16();
            ushort chunkNumber = eventRecordReader.ReadUInt16();

            if (!(format == 1 && magic == 0x5B))
            {
                return null;
            }

            EventSourceManifest manifest;
            if (!cache.TryGetValue(providerGuid, out manifest))
            {
                manifest = new EventSourceManifest(eventRecord->ProviderId, format, majorVersion, minorVersion, magic, totalChunks);
                cache.Add(providerGuid, manifest);
            }

            // if manifest is complete, maybe the data changed? ideally version should have changed
            // this is essentially a reset
            if (manifest.IsComplete && chunkNumber == 0)
            {
                cache[providerGuid] = manifest;
            }

            string schemaChunk = eventRecordReader.ReadAnsiString();
            manifest.AddChunk(schemaChunk);

            return manifest;
        }

        private unsafe IEventTraceOperand BuildOperand(EVENT_RECORD* eventRecord, EventRecordReader eventRecordReader, int metadataTableIndex, ref bool isSpecialKernelTraceMetaDataEvent)
        {
            if (eventRecord->ProviderId == CustomParserGuids.KernelTraceControlMetaDataGuid && eventRecord->Opcode == 32)
            {
                isSpecialKernelTraceMetaDataEvent = true;
                return EventTraceOperandBuilder.Build((TRACE_EVENT_INFO*)eventRecord->UserData, metadataTableIndex);
            }

            IEventTraceOperand operand;
            if ((operand = BuildOperandFromTdh(eventRecord, metadataTableIndex)) == null)
            {
                operand = BuildOperandFromXml(eventRecord, this.eventSourceManifestCache, eventRecordReader, metadataTableIndex);
            }

            if (operand == null && eventRecord->Id != 65534) // don't show manifest events
            {
                operand = BuildUnknownOperand(eventRecord, metadataTableIndex);
            }

            return operand;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private unsafe bool CustomParserLookup(EVENT_RECORD* eventRecord, ref TraceEventKey key)
        {
            bool success;

            // events added by KernelTraceControl.dll (i.e. Microsoft tools like WPR and PerfView)
            if (eventRecord->ProviderId == CustomParserGuids.KernelTraceControlImageIdGuid)
            {
                switch (eventRecord->Opcode)
                {
                    case 0:
                        this.actionTable.Add(key, new KernelTraceControlImageIdParser().Parse);
                        success = true;
                        break;
                    case 36:
                        this.actionTable.Add(key, new KernelTraceControlDbgIdParser().Parse);
                        success = true;
                        break;
                    case 64:
                        this.actionTable.Add(key, new KernelTraceControlImageIdFileVersionParser().Parse);
                        success = true;
                        break;
                    default:
                        success = false;
                        break;
                }
            }

            // events by the Kernel Stack Walker (need this because the MOF events always says 32 stacks, but in reality there can be fewer or more
            else if (eventRecord->ProviderId == CustomParserGuids.KernelStackWalkGuid)
            {
                if (eventRecord->Opcode == 32)
                {
                    this.actionTable.Add(key, new KernelStackWalkEventParser().Parse);
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            else
            {
                success = false;
            }

            return success;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private unsafe void SlowLookup(EVENT_RECORD* eventRecord, EventRecordReader eventRecordReader, RuntimeEventMetadata runtimeMetadata, ref TraceEventKey key)
        {
            if (this.CustomParserLookup(eventRecord, ref key))
            {
                return;
            }

            bool isSpecialKernelTraceMetaDataEvent = false;
            var operand = this.BuildOperand(eventRecord, eventRecordReader, this.eventMetadataTableList.Count, ref isSpecialKernelTraceMetaDataEvent);
            if (operand != null)
            {
                this.eventMetadataTableList.Add(operand.Metadata);
                this.eventMetadataTable = this.eventMetadataTableList.ToArray(); // TODO: Need to improve this

                var eventRecordReaderParam = Expression.Parameter(ReaderType);
                var eventWriterParam = Expression.Parameter(WriterType);
                var eventMetadataTableParam = Expression.Parameter(EventMetadataArrayType);
                var runtimeMetadataParam = Expression.Parameter(RuntimeMetadataType);

                var parameters = new[] { eventRecordReaderParam, eventWriterParam, eventMetadataTableParam, runtimeMetadataParam };
                var name = Regex.Replace(InvalidCharacters.Replace(operand.Metadata.Name, "_"), @"\s+", "_");
                var body = EventTraceOperandExpressionBuilder.Build(operand, eventRecordReaderParam, eventWriterParam, eventMetadataTableParam, runtimeMetadataParam);
                LambdaExpression expression = Expression.Lambda<Action<EventRecordReader, T, EventMetadata[], RuntimeEventMetadata>>(body, "Read_" + name, parameters);

                var assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName(name), AssemblyBuilderAccess.RunAndCollect);
                var moduleBuilder = assemblyBuilder.DefineDynamicModule(name, name + ".dll");

                var typeBuilder = moduleBuilder.DefineType(name, TypeAttributes.Public);
                var methodBuilder = typeBuilder.DefineMethod("Read", MethodAttributes.Public | MethodAttributes.Static, typeof(void), new[] { ReaderType, WriterType, EventMetadataArrayType, RuntimeMetadataType });

                expression.CompileToMethod(methodBuilder);
                var action = (Action<EventRecordReader, T, EventMetadata[], RuntimeEventMetadata>)Delegate.CreateDelegate(expression.Type, typeBuilder.CreateType().GetMethod("Read"));

                if (isSpecialKernelTraceMetaDataEvent)
                {
                    var e = (TRACE_EVENT_INFO*)eventRecord->UserDataFixed;
                    this.actionTable.AddOrUpdate(new TraceEventKey(e->ProviderGuid, e->EventGuid == Guid.Empty ? e->Id : e->Opcode, e->Version), action);
                }
                else
                {
                    this.actionTable.Add(key, action);
                    action(eventRecordReader, this.writer, this.eventMetadataTable, runtimeMetadata);
                }
            }
        }
    }
}