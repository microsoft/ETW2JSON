namespace ETWDeserializer
{
    using System;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Text;

    internal sealed class EventSourceManifest
    {
        private readonly StringBuilder chunkBuilder = new StringBuilder();

        private Guid providerGuid;

        private IntPtr providerEventInfoPtr;

        private IntPtr[] traceEventInfos;

        private readonly byte format;

        private readonly byte majorVersion;

        private readonly byte minorVersion;

        private readonly byte magic;

        private readonly ushort totalChunks;

        private ushort chunksReceived;

        public EventSourceManifest(Guid providerGuid, byte format, byte majorVersion, byte minorVersion, byte magic, ushort totalChunks)
        {
            this.providerGuid = providerGuid;
            this.format = format;
            this.majorVersion = majorVersion;
            this.minorVersion = minorVersion;
            this.magic = magic;
            this.totalChunks = totalChunks;
            this.providerEventInfoPtr = IntPtr.Zero;
        }

        ~EventSourceManifest()
        {
            if (this.providerEventInfoPtr != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(this.providerEventInfoPtr);
            }

            if (this.traceEventInfos != null)
            {
                for (int i = 0; i < this.traceEventInfos.Length; ++i)
                {
                    var traceEventInfo = this.traceEventInfos[i];
                    if (traceEventInfo != IntPtr.Zero)
                    {
                        Marshal.FreeHGlobal(traceEventInfo);
                    }
                }
            }
        }

        public bool IsComplete => this.chunksReceived == this.totalChunks;

        public Guid ProviderGuid => this.providerGuid;

        public byte Format => this.format;

        public byte MajorVersion => this.majorVersion;

        public byte MinorVersion => this.minorVersion;

        public byte Magic => this.magic;

        public ushort TotalChunks => this.totalChunks;

        public bool LoadSchema()
        {
            if (this.chunksReceived != this.totalChunks)
            {
                throw new Exception("Schema is incomplete as not all chunks have been received");
            }

            if (this.providerEventInfoPtr == IntPtr.Zero)
            {
                var tempPath = Path.GetTempFileName();
                File.WriteAllText(tempPath, this.chunkBuilder.ToString());
                int retVal = Tdh.LoadManifest(tempPath);

                if (retVal != 0)
                {
                    if (retVal == 1465)
                    {
                        Console.WriteLine($"TdhLoadManifest failed for Provider Id: {this.ProviderGuid} with error code because of an XML parsing error. MC.exe can be used to diagnose the failure.");
                    }
                    else
                    {
                        Console.WriteLine($"TdhLoadManifest failed for Provider Id: {this.ProviderGuid} with error code ({retVal}).");
                    }

                    return false;
                }

                unsafe
                {
                    int bufferSize = 0;
                    if ((retVal = Tdh.EnumerateManifestProviderEvents(ref this.providerGuid, IntPtr.Zero, out bufferSize)) == 122)
                    {
                        this.providerEventInfoPtr = Marshal.AllocHGlobal(bufferSize);
                        if ((retVal = Tdh.EnumerateManifestProviderEvents(ref this.providerGuid, this.providerEventInfoPtr, out bufferSize)) == 0)
                        {
                            var providerEventInfo = (PROVIDER_EVENT_INFO*)this.providerEventInfoPtr;
                            this.traceEventInfos = new IntPtr[providerEventInfo->NumberOfEvents];

                            for (uint i = 0; i < providerEventInfo->NumberOfEvents; ++i)
                            {
                                bufferSize = 0;
                                EVENT_DESCRIPTOR* descriptor = (EVENT_DESCRIPTOR*)((byte*)providerEventInfo + 8 + sizeof(EVENT_DESCRIPTOR) * i);

                                if ((retVal = Tdh.GetManifestEventInformation(ref this.providerGuid, descriptor, IntPtr.Zero, out bufferSize)) == 122)
                                {
                                    IntPtr traceEventInfoPtr = Marshal.AllocHGlobal(bufferSize);
                                    if ((retVal = Tdh.GetManifestEventInformation(ref this.providerGuid, descriptor, traceEventInfoPtr, out bufferSize)) == 0)
                                    {
                                        this.traceEventInfos[i] = traceEventInfoPtr;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"GetManifestEventInformation : {retVal}");
                                        return false;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"GetManifestEventInformation failed : {retVal}");
                                    return false;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"EnumerateManifestProviderEvents failed : {retVal}");
                            return false;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"EnumerateManifestProviderEvents failed : {retVal}");

                        return false;
                    }
                }

                retVal = Tdh.UnloadManifest(tempPath);

                if (retVal != 0)
                {
                    return false;
                }
            }

            return true;
        }

        public IEventTraceOperand GetTraceEventInfo(ushort eventId, byte version)
        {
            unsafe
            {
                var providerEventInfo = (PROVIDER_EVENT_INFO*)this.providerEventInfoPtr;
                for (uint i = 0; i < providerEventInfo->NumberOfEvents; ++i)
                {
                    EVENT_DESCRIPTOR* descriptor = (EVENT_DESCRIPTOR*)((byte*)providerEventInfo + 8 + sizeof(EVENT_DESCRIPTOR) * i);

                    if (descriptor->Id == eventId && descriptor->Version == version)
                    {
                        return EventTraceOperandBuilder.Build((TRACE_EVENT_INFO*)this.traceEventInfos[i]);
                    }
                }
            }

            return null;
        }

        public void AddChunk(string schemaChunk)
        {
            this.chunkBuilder.Append(schemaChunk);
            ++this.chunksReceived;
        }

        public override bool Equals(object obj)
        {
            var other = obj as EventSourceManifest;
            return other != null && this.Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = this.providerGuid.GetHashCode();
                hashCode = (hashCode * 397) ^ this.format.GetHashCode();
                hashCode = (hashCode * 397) ^ this.majorVersion.GetHashCode();
                hashCode = (hashCode * 397) ^ this.minorVersion.GetHashCode();
                hashCode = (hashCode * 397) ^ this.magic.GetHashCode();
                hashCode = (hashCode * 397) ^ this.totalChunks.GetHashCode();

                return hashCode;
            }
        }

        public bool Equals(EventSourceManifest other)
        {
            return this.providerGuid.Equals(other.providerGuid)
                   && this.format == other.format
                   && this.majorVersion == other.majorVersion
                   && this.minorVersion == other.minorVersion
                   && this.magic == other.magic
                   && this.totalChunks == other.totalChunks;
        }
    }
}