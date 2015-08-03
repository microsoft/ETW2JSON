namespace ETW2JSON
{
    using System;
    using System.Runtime.InteropServices;
    using System.Security;
    using ETWDeserializer;

    using ULONG = System.UInt32;
    using LONG = System.Int32;
    using ULONGLONG = System.UInt64;
    using LONGLONG = System.Int64;
    using LARGE_INTEGER = System.Int64;
    using USHORT = System.UInt16;
    using GUID = System.Guid;
    using UCHAR = System.Byte;
    using LPWSTR = System.String;
    
    [StructLayout(LayoutKind.Sequential)]
    internal struct TRACE_LOGFILE_HEADER
    {
        public ULONG BufferSize;         // Logger buffer size in Kbytes
        public ULONG Version;            // Logger version
        public ULONG ProviderVersion;    // defaults to NT version
        public ULONG NumberOfProcessors; // Number of Processors
        public LARGE_INTEGER EndTime;            // Time when logger stops
        public ULONG TimerResolution;    // assumes timer is constant!!!
        public ULONG MaximumFileSize;    // Maximum in Mbytes
        public ULONG LogFileMode;        // specify logfile mode
        public ULONG BuffersWritten;     // used to file start of Circular File

        public ULONG StartBuffers;       // Count of buffers written at start.
        public ULONG PointerSize;        // Size of pointer type in bits
        public ULONG EventsLost;         // Events losts during log session
        public ULONG CpuSpeedInMHz;      // Cpu Speed in MHz

        public IntPtr LoggerName;
        public IntPtr LogFileName;
        public TIME_ZONE_INFORMATION TimeZone;

        public LARGE_INTEGER BootTime;
        public LARGE_INTEGER PerfFreq;           // Reserved
        public LARGE_INTEGER StartTime;          // Reserved
        public ULONG ReservedFlags;      // ClockType
        public ULONG BuffersLost;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct EVENT_TRACE_HEADER // overlays WNODE_HEADER
    {
        public USHORT Size; // Size of entire record

        public USHORT FieldTypeFlags; // Indicates valid fields

        public UCHAR Type; // event type
        public UCHAR Level; // trace instrumentation level
        public USHORT Version; // version of trace record

        public ULONG ThreadId; // Thread Id
        public ULONG ProcessId; // Process Id
        public LARGE_INTEGER TimeStamp; // time when event happens
        public GUID Guid; // Guid that identifies event

        public ULONG KernelTime; // Kernel Mode CPU ticks
        public ULONG UserTime; // User mode CPU ticks
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct EVENT_TRACE
    {
        public EVENT_TRACE_HEADER Header; // Event trace header
        public ULONG InstanceId; // Instance Id of this event
        public ULONG ParentInstanceId; // Parent Instance Id.
        public GUID ParentGuid; // Parent Guid;
        public IntPtr MofData; // Pointer to Variable Data
        public ULONG MofLength; // Variable Datablock Length

        public UCHAR ProcessorNumber;
        public UCHAR Alignment;
        public USHORT LoggerId;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct EVENT_TRACE_LOGFILEW
    {
        [MarshalAs(UnmanagedType.LPWStr)]
        public LPWSTR LogFileName; // Logfile Name

        [MarshalAs(UnmanagedType.LPWStr)]
        public LPWSTR LoggerName; // LoggerName

        public LONGLONG CurrentTime; // timestamp of last event
        public ULONG BuffersRead; // buffers read to date

        public ULONG LogFileMode; // Mode of the logfile

        public EVENT_TRACE CurrentEvent; // Current Event from this stream.
        public TRACE_LOGFILE_HEADER LogfileHeader; // logfile header structure
        public PEVENT_TRACE_BUFFER_CALLBACKW BufferCallback; // callback before each buffer is read
        //
        // following variables are filled for BufferCallback.
        //
        public LONG BufferSize;
        public LONG Filled;
        public LONG EventsLost;
        //
        // following needs to be propaged to each buffer
        //

        // Callback with EVENT_RECORD on Vista and above
        public PEVENT_RECORD_CALLBACK EventRecordCallback;

        public ULONG IsKernelTrace; // TRUE for kernel logfile

        public IntPtr Context; // reserved for internal use
    }

    [StructLayout(LayoutKind.Sequential, Size = 0xAC, CharSet = CharSet.Unicode)]
    internal struct TIME_ZONE_INFORMATION
    {
        public ULONG Bias;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string StandardName;

        [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U2, SizeConst = 8)]
        public USHORT[] StandardDate;

        public ULONG StandardBias;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DaylightName;

        [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U2, SizeConst = 8)]
        public USHORT[] DaylightDate;

        public ULONG DaylightBias;
    }

    internal delegate bool PEVENT_TRACE_BUFFER_CALLBACKW([In] IntPtr logfile);

    internal unsafe delegate void PEVENT_RECORD_CALLBACK([In] EVENT_RECORD* eventRecord);

    internal static class Etw
    {
        [DllImport("advapi32.dll", EntryPoint = "OpenTraceW", CharSet = CharSet.Unicode, SetLastError = true), SuppressUnmanagedCodeSecurity]
        internal static extern UInt64 OpenTrace([In] [Out] ref EVENT_TRACE_LOGFILEW Logfile);

        [DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true), SuppressUnmanagedCodeSecurityAttribute]
        internal extern static int ProcessTrace([In] ULONGLONG[] HandleArray, [In] ULONG HandleCount, [In] IntPtr StartTime, [In] IntPtr EndTime);

        [DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true), SuppressUnmanagedCodeSecurityAttribute]
        internal extern static int CloseTrace([In] ULONGLONG TraceHandle);

        internal const ULONG EVENT_TRACE_REAL_TIME_MODE = 0x00000100; // Real time mode on
        internal const ULONG ENABLE_TRACE_PARAMETERS_VERSION = 1;
        internal const ULONG EVENT_CONTROL_CODE_DISABLE_PROVIDER = 0;
        internal const ULONG EVENT_CONTROL_CODE_ENABLE_PROVIDER = 1;
        internal const ULONG EVENT_CONTROL_CODE_CAPTURE_STATE = 2;

        internal const ULONG EVENT_TRACE_FILE_MODE_NONE = 0x00000000;
        internal const ULONG EVENT_TRACE_FILE_MODE_SEQUENTIAL = 0x00000001;
        internal const ULONG EVENT_TRACE_FILE_MODE_CIRCULAR = 0x00000002;
        internal const ULONG EVENT_TRACE_FILE_MODE_APPEND = 0x00000004;
        internal const ULONG EVENT_TRACE_FILE_MODE_NEWFILE = 0x00000008;

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

        internal const ULONG PROCESS_TRACE_MODE_EVENT_RECORD = 0x10000000;
        internal const ULONG PROCESS_TRACE_MODE_REAL_TIME = 0x00000100;
        internal const ULONG PROCESS_TRACE_MODE_RAW_TIMESTAMP = 0x00001000;

        internal const ULONG EVENT_TRACE_CONTROL_QUERY = 0;
        internal const ULONG EVENT_TRACE_CONTROL_STOP = 1;
        internal const ULONG EVENT_TRACE_CONTROL_UPDATE = 2;
        internal const ULONG EVENT_TRACE_CONTROL_FLUSH = 3;

        internal const ULONG WNODE_FLAG_TRACED_GUID = 0x00020000;
    }
}