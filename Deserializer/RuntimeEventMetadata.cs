namespace ETWDeserializer
{
    using System;

    public struct RuntimeEventMetadata
    {
        private readonly unsafe EVENT_RECORD* eventRecord;

        internal unsafe RuntimeEventMetadata(EVENT_RECORD* eventRecord)
        {
            this.eventRecord = eventRecord;
        }

        public ushort Flags
        {
            get
            {
                unsafe
                {
                    return this.eventRecord->Flags;
                }
            }
        }

        public uint ThreadId
        {
            get
            {
                unsafe
                {
                    return this.eventRecord->ThreadId;
                }
            }
        }

        public uint ProcessId
        {
            get
            {
                unsafe
                {
                    return this.eventRecord->ProcessId;
                }
            }
        }

        public long Timestamp
        {
            get
            {
                unsafe
                {
                    return this.eventRecord->TimeStamp;
                }
            }
        }

        public Guid ProviderId
        {
            get
            {
                unsafe
                {
                    return this.eventRecord->ProviderId;
                }
            }
        }

        public ushort EventId
        {
            get
            {
                unsafe
                {
                    return this.eventRecord->Id;
                }
            }
        }

        public Guid ActivityId
        {
            get
            {
                unsafe
                {
                    return this.eventRecord->ActivityId;
                }
            }
        }

        public ushort UserDataLength
        {
            get
            {
                unsafe
                {
                    return this.eventRecord->UserDataLength;
                }
            }
        }

        public Guid RelatedActivityId
        {
            get
            {
                unsafe
                {
                    var extendedData = this.eventRecord->ExtendedData;
                    for (int i = 0; i < this.eventRecord->ExtendedDataCount; ++i)
                    {
                        if (extendedData[i].ExtType == Etw.EVENT_HEADER_EXT_TYPE_RELATED_ACTIVITYID)
                        {
                            return *((Guid*)extendedData[i].DataPtr);
                        }
                    }

                    return Guid.Empty;
                }
            }
        }

        public ushort ProcessorNumber
        {
            get
            {
                unsafe
                {
                    return this.eventRecord->ProcessorNumber;
                }
            }
        }

        // logic from: https://msdn.microsoft.com/en-us/library/windows/desktop/dd392308(v=vs.85).aspx
        public ulong[] GetStacks(out ulong matchId)
        {
            unsafe
            {
                var extendedData = this.eventRecord->ExtendedData;
                for (int i = 0; i < this.eventRecord->ExtendedDataCount; ++i)
                {
                    switch (extendedData[i].ExtType)
                    {
                        case Etw.EVENT_HEADER_EXT_TYPE_STACK_TRACE32:
                        {
                            var numberOfInstructionPointers = (extendedData[i].DataSize - sizeof(ulong)) / sizeof(uint);
                            return GetStacks32(numberOfInstructionPointers, ref extendedData[i], out matchId);
                        }

                        case Etw.EVENT_HEADER_EXT_TYPE_STACK_TRACE64:
                        {
                            var numberOfInstructionPointers = (extendedData[i].DataSize - sizeof(ulong)) / sizeof(ulong);
                            return GetStacks64(numberOfInstructionPointers, ref extendedData[i], out matchId);
                        }
                    }
                }

                matchId = 0;
                return null;
            }
        }

        private static unsafe ulong[] GetStacks64(int numberOfInstructionPointers, ref EVENT_HEADER_EXTENDED_DATA_ITEM extendedData, out ulong matchId)
        {
            var retArr = new ulong[numberOfInstructionPointers];
            matchId = *(ulong*)extendedData.DataPtr;

            extendedData.DataPtr += sizeof(ulong);

            var dataPtr = (ulong*)extendedData.DataPtr;

            for (int j = 0; j < numberOfInstructionPointers; ++j)
            {
                retArr[j] = *dataPtr;
                dataPtr++;
            }

            return retArr;
        }

        private static unsafe ulong[] GetStacks32(int numberOfInstructionPointers, ref EVENT_HEADER_EXTENDED_DATA_ITEM extendedData, out ulong matchId)
        {
            var retArr = new ulong[numberOfInstructionPointers];
            matchId = *(ulong*)extendedData.DataPtr;

            extendedData.DataPtr += sizeof(ulong);

            var dataPtr = (int*)extendedData.DataPtr;

            for (int j = 0; j < numberOfInstructionPointers; ++j)
            {
                retArr[j] = (ulong)*dataPtr;
                dataPtr++;
            }

            return retArr;
        }
    }
}