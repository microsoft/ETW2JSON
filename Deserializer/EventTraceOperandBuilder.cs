namespace ETWDeserializer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;

    internal static unsafe class EventTraceOperandBuilder
    {
        public static IEventTraceOperand Build(TRACE_EVENT_INFO* traceEventInfo)
        {
            return new EventTraceOperandBuilderFromTDH(traceEventInfo).Build();
        }

        private sealed class EventTraceOperandBuilderFromTDH
        {
            private readonly TRACE_EVENT_INFO* traceEventInfo;

            private readonly List<IEventTracePropertyOperand> flatPropertyList = new List<IEventTracePropertyOperand>();

            public EventTraceOperandBuilderFromTDH(TRACE_EVENT_INFO* traceEventInfo)
            {
                this.traceEventInfo = traceEventInfo;
            }

            public IEventTraceOperand Build()
            {
                var buffer = (byte*)this.traceEventInfo;
                EVENT_PROPERTY_INFO* eventPropertyInfoArr = (EVENT_PROPERTY_INFO*)&this.traceEventInfo->EventPropertyInfoArray;

                string provider = this.BuildName("Provider", this.traceEventInfo->ProviderGuid.ToString(), this.traceEventInfo->ProviderNameOffset);
                string task = this.BuildName("EventID", this.traceEventInfo->Id.ToString(), this.traceEventInfo->TaskNameOffset);
                string opcode = this.BuildName("Opcode", this.traceEventInfo->Opcode.ToString(), this.traceEventInfo->OpcodeNameOffset);

                //WPP properties not supported
                int end = this.traceEventInfo->DecodingSource == DECODING_SOURCE.DecodingSourceWPP ? 0 : (int)traceEventInfo->TopLevelPropertyCount;
                var topLevelOperands = this.IterateProperties(buffer, 0, end, eventPropertyInfoArr);
                return new EventTraceOperand(new EventMetadata(this.traceEventInfo->ProviderGuid, this.traceEventInfo->Id, this.traceEventInfo->Version, provider + "/" + task + "/" + opcode, this.flatPropertyList.Select(t => t.Metadata).ToArray()), topLevelOperands);
            }

            private string BuildName(string prefix, string value, uint offset)
            {
                var buffer = (byte*)this.traceEventInfo;
                string item = prefix + "(" + value + ")";
                if (offset != 0)
                {
                    item = new string((char*)&buffer[offset]).Trim();
                }

                return item;
            }

            private List<EventTracePropertyOperand> IterateProperties(byte* buffer, int start, int end, EVENT_PROPERTY_INFO* eventPropertyInfoArr)
            {
                var operands = new List<EventTracePropertyOperand>();
                return this.IterateProperties(buffer, operands, start, end, eventPropertyInfoArr);
            }

            private List<EventTracePropertyOperand> IterateProperties(byte* buffer, List<EventTracePropertyOperand> operands, int start, int end, EVENT_PROPERTY_INFO* eventPropertyInfoArr)
            {
                var returnList = new List<EventTracePropertyOperand>();
                for (int i = start; i < end; ++i)
                {
                    var eventPropertyInfo = &eventPropertyInfoArr[i];
                    string propertyName = new string((char*)&buffer[eventPropertyInfo->NameOffset]);

                    int structchildren = eventPropertyInfo->StructType.NumOfStructMembers;
                    bool isStruct = (eventPropertyInfo->Flags & PROPERTY_FLAGS.PropertyStruct) == PROPERTY_FLAGS.PropertyStruct;
                    bool isVariableArray = (eventPropertyInfo->Flags & PROPERTY_FLAGS.PropertyParamCount) == PROPERTY_FLAGS.PropertyParamCount;
                    bool isFixedArray = (eventPropertyInfo->Flags & PROPERTY_FLAGS.PropertyParamFixedCount) == PROPERTY_FLAGS.PropertyParamFixedCount;
                    bool isVariableLength = (eventPropertyInfo->Flags & PROPERTY_FLAGS.PropertyParamLength) == PROPERTY_FLAGS.PropertyParamLength;
                    bool isFixedLength = (eventPropertyInfo->Flags & PROPERTY_FLAGS.PropertyParamFixedLength) == PROPERTY_FLAGS.PropertyParamFixedLength;
                    bool isWbemXmlFragment = (eventPropertyInfo->Flags & PROPERTY_FLAGS.PropertyWBEMXmlFragment) == PROPERTY_FLAGS.PropertyWBEMXmlFragment;

                    // NOTE: Do not remove this special case, there are cases like this, we just assume it's a fixed array
                    if (!isFixedArray && !isVariableArray && eventPropertyInfo->count > 1)
                    {
                        isFixedArray = true;
                    }

                    string mapName = null;
                    Dictionary<uint, string> mapOfValues = null;
                    if (eventPropertyInfo->NonStructType.MapNameOffset != 0)
                    {
                        byte* mapBuffer = (byte*)0;
                        uint bufferSize;

                        var fakeEventRecord = new EVENT_RECORD { ProviderId = this.traceEventInfo->ProviderGuid };

                        mapName = new string((char*)&buffer[eventPropertyInfo->NonStructType.MapNameOffset]);

                        Tdh.GetEventMapInformation(&fakeEventRecord, mapName, mapBuffer, out bufferSize);
                        mapBuffer = (byte*)Marshal.AllocHGlobal((int)bufferSize);
                        Tdh.GetEventMapInformation(&fakeEventRecord, mapName, mapBuffer, out bufferSize);

                        EVENT_MAP_INFO* mapInfo = (EVENT_MAP_INFO*)mapBuffer;
                        if (mapInfo->MapEntryValueType == MAP_VALUETYPE.EVENTMAP_ENTRY_VALUETYPE_ULONG)
                        {
                            var mapEntry = (EVENT_MAP_ENTRY*)&mapInfo->MapEntryArray;
                            mapOfValues = new Dictionary<uint, string>();
                            for (int j = 0; j < mapInfo->EntryCount; ++j)
                            {
                                var offset = mapEntry[j].OutputOffset;
                                if (offset > bufferSize)
                                {
                                     // TDH has a bug (it seems) that is giving rogue values here
                                     // We should log this
                                }
                                else
                                {
                                    var mapEntryValue = mapEntry[j].Value;
                                    string mapEntryName;
                                    if (!mapOfValues.TryGetValue(mapEntryValue, out mapEntryName))
                                    {
                                        mapEntryName = new string((char*)&mapBuffer[offset]);
                                        mapOfValues.Add(mapEntryValue, mapEntryName);
                                    }
                                }
                            }
                        }

                        Marshal.FreeHGlobal((IntPtr)mapBuffer);
                    }

                    /* save important information in an object */
                    var operand = new EventTracePropertyOperand(
                        new PropertyMetadata((TDH_IN_TYPE)eventPropertyInfo->NonStructType.InType, (TDH_OUT_TYPE)eventPropertyInfo->NonStructType.OutType, propertyName, mapOfValues != null, isStruct, isStruct ? structchildren : 0, new MapInformation(mapName, mapOfValues)),
                        i,
                        isVariableArray,
                        isFixedArray,
                        isVariableLength,
                        isFixedLength,
                        isWbemXmlFragment);

                    this.flatPropertyList.Add(operand);
                    operands.Add(operand);
                    returnList.Add(operand);

                    /* if this references a previous field, we need to capture that as a local */
                    if (isVariableArray)
                    {
                        var reference = operands[eventPropertyInfo->countPropertyIndex];
                        reference.IsReferencedByOtherProperties = true;
                        operand.SetVariableArraySize(reference);
                    }
                    else if (isFixedArray)
                    {
                        operand.SetFixedArraySize(eventPropertyInfo->count);
                    }

                    /* if this references a previous field, we need to capture that as a local */
                    if (isVariableLength)
                    {
                        var reference = operands[eventPropertyInfo->lengthPropertyIndex];
                        reference.IsReferencedByOtherProperties = true;
                        operand.SetVariableLengthSize(reference);
                    }
                    else if (isFixedLength)
                    {
                        operand.SetFixedLengthSize(eventPropertyInfo->length);
                    }

                    if ((eventPropertyInfo->Flags & PROPERTY_FLAGS.PropertyStruct) == PROPERTY_FLAGS.PropertyStruct)
                    {
                        var innerProps = this.IterateProperties(
                            buffer,
                            operands,
                            eventPropertyInfo->StructType.StructStartIndex,
                            eventPropertyInfo->StructType.StructStartIndex + eventPropertyInfo->StructType.NumOfStructMembers,
                            eventPropertyInfoArr);

                        foreach (var innerProp in innerProps)
                        {
                            operand.Children.Add(innerProp);
                        }
                    }
                }

                return returnList;
            }
        }
    }

    internal sealed class UnknownOperandBuilder : IEventTraceOperand
    {
        public UnknownOperandBuilder(Guid providerGuid)
        {
            this.Metadata = new EventMetadata(providerGuid, 0, 0, "UnknownProvider(" + providerGuid.ToString() + ")", new PropertyMetadata[0]);
        }

        public EventMetadata Metadata { get; set; }

        public IEnumerable<IEventTracePropertyOperand> EventPropertyOperands => Enumerable.Empty<IEventTracePropertyOperand>();
    }
}