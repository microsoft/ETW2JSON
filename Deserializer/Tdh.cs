namespace ETWDeserializer
{
    using System;
    using System.Runtime.InteropServices;
    using System.Security;
    using ULONG = System.UInt32;
    using ULONGLONG = System.UInt64;
    using USHORT = System.UInt16;
    using GUID = System.Guid;
    using UCHAR = System.Byte;

    [StructLayout(LayoutKind.Explicit)]
    internal struct EVENT_MAP_ENTRY
    {
        [FieldOffset(0)]
        public ULONG OutputOffset;

        [FieldOffset(4)]
        public ULONG Value; // For ULONG value (valuemap and bitmap).

        [FieldOffset(4)]
        public ULONG InputOffset; // For String value (patternmap or valuemap in WBEM).
    }

    [Flags]
    internal enum MAP_FLAGS
    {
        EVENTMAP_INFO_FLAG_MANIFEST_VALUEMAP = 0x1,
        EVENTMAP_INFO_FLAG_MANIFEST_BITMAP = 0x2,
        EVENTMAP_INFO_FLAG_MANIFEST_PATTERNMAP = 0x4,
        EVENTMAP_INFO_FLAG_WBEM_VALUEMAP = 0x8,
        EVENTMAP_INFO_FLAG_WBEM_BITMAP = 0x10,
        EVENTMAP_INFO_FLAG_WBEM_FLAG = 0x20,
        EVENTMAP_INFO_FLAG_WBEM_NO_MAP = 0x40
    }

    internal enum MAP_VALUETYPE
    {
        EVENTMAP_ENTRY_VALUETYPE_ULONG,
        EVENTMAP_ENTRY_VALUETYPE_STRING
    }

    [StructLayout(LayoutKind.Explicit)]
    internal unsafe struct EVENT_MAP_INFO
    {
        [FieldOffset(0)]
        public ULONG NameOffset;

        [FieldOffset(4)]
        public MAP_FLAGS Flag;

        [FieldOffset(8)]
        public ULONG EntryCount;

        [FieldOffset(12)]
        public MAP_VALUETYPE MapEntryValueType;

        [FieldOffset(12)]
        public ULONG FormatStringOffset;

        [FieldOffset(16)]
        public EVENT_MAP_ENTRY* MapEntryArray;
    }

    // Intypes and outtypes are defined in winmeta.xml.
    public enum TDH_IN_TYPE
    {
        TDH_INTYPE_NULL,
        TDH_INTYPE_UNICODESTRING,
        TDH_INTYPE_ANSISTRING,
        TDH_INTYPE_INT8,
        TDH_INTYPE_UINT8,
        TDH_INTYPE_INT16,
        TDH_INTYPE_UINT16,
        TDH_INTYPE_INT32,
        TDH_INTYPE_UINT32,
        TDH_INTYPE_INT64,
        TDH_INTYPE_UINT64,
        TDH_INTYPE_FLOAT,
        TDH_INTYPE_DOUBLE,
        TDH_INTYPE_BOOLEAN,
        TDH_INTYPE_BINARY,
        TDH_INTYPE_GUID,
        TDH_INTYPE_POINTER,
        TDH_INTYPE_FILETIME,
        TDH_INTYPE_SYSTEMTIME,
        TDH_INTYPE_SID,
        TDH_INTYPE_HEXINT32,
        TDH_INTYPE_HEXINT64, // End of winmeta intypes.
        TDH_INTYPE_COUNTEDSTRING = 300, // Start of TDH intypes for WBEM.
        TDH_INTYPE_COUNTEDANSISTRING,
        TDH_INTYPE_REVERSEDCOUNTEDSTRING,
        TDH_INTYPE_REVERSEDCOUNTEDANSISTRING,
        TDH_INTYPE_NONNULLTERMINATEDSTRING,
        TDH_INTYPE_NONNULLTERMINATEDANSISTRING,
        TDH_INTYPE_UNICODECHAR,
        TDH_INTYPE_ANSICHAR,
        TDH_INTYPE_SIZET,
        TDH_INTYPE_HEXDUMP,
        TDH_INTYPE_WBEMSID
    }

    public enum TDH_OUT_TYPE
    {
        TDH_OUTTYPE_NULL,
        TDH_OUTTYPE_STRING,
        TDH_OUTTYPE_DATETIME,
        TDH_OUTTYPE_BYTE,
        TDH_OUTTYPE_UNSIGNEDBYTE,
        TDH_OUTTYPE_SHORT,
        TDH_OUTTYPE_UNSIGNEDSHORT,
        TDH_OUTTYPE_INT,
        TDH_OUTTYPE_UNSIGNEDINT,
        TDH_OUTTYPE_LONG,
        TDH_OUTTYPE_UNSIGNEDLONG,
        TDH_OUTTYPE_FLOAT,
        TDH_OUTTYPE_DOUBLE,
        TDH_OUTTYPE_BOOLEAN,
        TDH_OUTTYPE_GUID,
        TDH_OUTTYPE_HEXBINARY,
        TDH_OUTTYPE_HEXINT8,
        TDH_OUTTYPE_HEXINT16,
        TDH_OUTTYPE_HEXINT32,
        TDH_OUTTYPE_HEXINT64,
        TDH_OUTTYPE_PID,
        TDH_OUTTYPE_TID,
        TDH_OUTTYPE_PORT,
        TDH_OUTTYPE_IPV4,
        TDH_OUTTYPE_IPV6,
        TDH_OUTTYPE_SOCKETADDRESS,
        TDH_OUTTYPE_CIMDATETIME,
        TDH_OUTTYPE_ETWTIME,
        TDH_OUTTYPE_XML,
        TDH_OUTTYPE_ERRORCODE,
        TDH_OUTTYPE_WIN32ERROR,
        TDH_OUTTYPE_NTSTATUS,
        TDH_OUTTYPE_HRESULT, // End of winmeta outtypes.
        TDH_OUTTYPE_CULTURE_INSENSITIVE_DATETIME, // Culture neutral datetime string.
        TDH_OUTTYPE_JSON,
        TDH_OUTTYPE_REDUCEDSTRING = 300, // Start of TDH outtypes for WBEM.
        TDH_OUTTYPE_NOPRINT
    }

    [Flags]
    internal enum PROPERTY_FLAGS
    {
        PropertyStruct = 0x1, // Type is struct.
        PropertyParamLength = 0x2, // Length field is index of param with length.
        PropertyParamCount = 0x4, // Count file is index of param with count.
        PropertyWBEMXmlFragment = 0x8, // WBEM extension flag for property.
        PropertyParamFixedLength = 0x10, // Length of the parameter is fixed.
        PropertyParamFixedCount = 0x20, // Count of the parameter is fixed.
        PropertyHasTags = 0x40 // The Tags field has been initialized.
    }

    [StructLayout(LayoutKind.Explicit)]
    internal struct EVENT_PROPERTY_INFO
    {
        [FieldOffset(0)]
        public PROPERTY_FLAGS Flags;

        [FieldOffset(4)]
        public ULONG NameOffset;

        [FieldOffset(8)]
        public nonStructType NonStructType;

        [FieldOffset(8)]
        public structType StructType;

        [FieldOffset(16)]
        public USHORT count;

        [FieldOffset(16)]
        public USHORT countPropertyIndex;

        [FieldOffset(18)]
        public USHORT length;

        [FieldOffset(18)]
        public USHORT lengthPropertyIndex;

        [FieldOffset(18)]
        public ULONG Reserved;

        [StructLayout(LayoutKind.Sequential)]
        internal struct nonStructType
        {
            public USHORT InType;
            public USHORT OutType;
            public ULONG MapNameOffset;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct structType
        {
            public USHORT StructStartIndex;
            public USHORT NumOfStructMembers;
            public ULONG padding;
        }
    }

    internal enum DECODING_SOURCE
    {
        DecodingSourceXMLFile,
        DecodingSourceWbem,
        DecodingSourceWPP,
        DecodingSourceTlg,
        DecodingSourceMax
    }

    internal enum TEMPLATE_FLAGS
    {
        TEMPLATE_EVENT_DATA = 1, // Used when custom xml is not specified.
        TEMPLATE_USER_DATA = 2 // Used when custom xml is specified.
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct TRACE_EVENT_INFO
    {
        public GUID ProviderGuid;
        public GUID EventGuid;
        public USHORT Id;
        public UCHAR Version;
        public UCHAR Channel;
        public UCHAR Level;
        public UCHAR Opcode;
        public USHORT Task;
        public ULONGLONG Keyword;
        public DECODING_SOURCE DecodingSource;
        public ULONG ProviderNameOffset;
        public ULONG LevelNameOffset;
        public ULONG ChannelNameOffset;
        public ULONG KeywordsNameOffset;
        public ULONG TaskNameOffset;
        public ULONG OpcodeNameOffset;
        public ULONG EventMessageOffset;
        public ULONG ProviderMessageOffset;
        public ULONG BinaryXMLOffset;
        public ULONG BinaryXMLSize;
        public ULONG ActivityIDNameOffset;
        public ULONG RelatedActivityIDNameOffset;
        public ULONG PropertyCount;
        public ULONG TopLevelPropertyCount;
        public TEMPLATE_FLAGS Flags;
        public EVENT_PROPERTY_INFO* EventPropertyInfoArray;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct PROPERTY_DATA_DESCRIPTOR
    {
        public ULONGLONG PropertyName; // Pointer to property name.
        public ULONG ArrayIndex; // Array Index.
        public ULONG Reserved;
    }

    internal static class Tdh
    {
        [DllImport("tdh.dll", EntryPoint = "TdhGetEventInformation")]
        internal static extern unsafe int GetEventInformation(EVENT_RECORD* pEvent, uint TdhContextCount, IntPtr pTdhContext, byte* pBuffer, out uint pBufferSize);

        [DllImport("tdh.dll", EntryPoint = "TdhGetEventMapInformation", CharSet = CharSet.Unicode)]
        internal static extern unsafe int GetEventMapInformation(EVENT_RECORD* pEvent, string pMapName, byte* pBuffer, out uint pBufferSize);
    }
}