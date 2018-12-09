namespace ETWDeserializer
{
    using System.Runtime.InteropServices;

    using ULONG = System.UInt32;
    using ULONG64 = System.UInt64;
    using ULONGLONG = System.UInt64;
    using LARGE_INTEGER = System.Int64;
    using USHORT = System.UInt16;
    using GUID = System.Guid;
    using UCHAR = System.Byte;

    [StructLayout(LayoutKind.Sequential)]
    public struct PROVIDER_EVENT_INFO
    {
        public ULONG NumberOfEvents;
        public ULONG Reserved;
        public System.IntPtr EventDescriptorsArray;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EVENT_DESCRIPTOR
    {
        public USHORT Id;
        public UCHAR Version;
        public UCHAR Channel;
        public UCHAR Level;
        public UCHAR Opcode;
        public USHORT Task;
        public ULONGLONG Keyword;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct EVENT_RECORD
    {
        public USHORT Size; // Event Size
        public USHORT HeaderType; // Header Type
        public USHORT Flags; // Flags
        public USHORT EventProperty; // User given event property
        public ULONG ThreadId; // Thread Id
        public ULONG ProcessId; // Process Id
        public LARGE_INTEGER TimeStamp; // Event Timestamp
        public GUID ProviderId; // Provider Id
        public USHORT Id;
        public UCHAR Version;
        public UCHAR Channel;
        public UCHAR Level;
        public UCHAR Opcode;
        public USHORT Task;
        public ULONGLONG Keyword;
        public ULONG64 ProcessorTime; // Processor Clock
        public GUID ActivityId; // Activity Id
        public UCHAR ProcessorNumber;
        public UCHAR Alignment;
        public USHORT LoggerId;
        public USHORT ExtendedDataCount; // Number of extended // data items
        public USHORT UserDataLength; // User data length
        public EVENT_HEADER_EXTENDED_DATA_ITEM* ExtendedData; // Pointer to an array of extended data items
        public byte* UserData; // Pointer to user data
        public byte* UserDataFixed; // NOTE: actual field is "UserContext", but since we don't use it, using it for other purposes :-)
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EVENT_HEADER_EXTENDED_DATA_ITEM
    {
        public USHORT Reserved1;
        public USHORT ExtType;
        public USHORT Reserved2;
        public USHORT DataSize;
        public ULONGLONG DataPtr;
    }

    internal static class Etw
    {
        internal const USHORT EVENT_HEADER_EXT_TYPE_RELATED_ACTIVITYID = 0x0001;
        internal const USHORT EVENT_HEADER_EXT_TYPE_SID = 0x0002;
        internal const USHORT EVENT_HEADER_EXT_TYPE_TS_ID = 0x0003;
        internal const USHORT EVENT_HEADER_EXT_TYPE_INSTANCE_INFO = 0x0004;
        internal const USHORT EVENT_HEADER_EXT_TYPE_STACK_TRACE32 = 0x0005;
        internal const USHORT EVENT_HEADER_EXT_TYPE_STACK_TRACE64 = 0x0006;
        internal const USHORT EVENT_HEADER_EXT_TYPE_PEBS_INDEX = 0x0007;
        internal const USHORT EVENT_HEADER_EXT_TYPE_PMC_COUNTERS = 0x0008;

        internal const USHORT EVENT_HEADER_FLAG_STRING_ONLY = 0x0004;
        internal const USHORT EVENT_HEADER_FLAG_TRACE_MESSAGE = 0x0008;
        internal const USHORT EVENT_HEADER_FLAG_32_BIT_HEADER = 0x0020;
        internal const USHORT EVENT_HEADER_FLAG_64_BIT_HEADER = 0x0040;
        internal const USHORT EVENT_HEADER_FLAG_CLASSIC_HEADER = 0x0100;
    }
}