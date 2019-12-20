namespace ETW2JSON
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text.Json;
    using ETWDeserializer;
    
    public static class Program
    {
        private static readonly string Usage = "Usage: ETW2JSON filename.etl [filename2.etl] -output=filename.json";

        public static bool ConvertToJson(Utf8JsonWriter jsonWriter, IEnumerable<string> inputFiles, Action<string> reportError)
        {
            var list = inputFiles.ToList();
            var deserializer = new Deserializer<EtwJsonWriter>(new EtwJsonWriter(jsonWriter));

            Stopwatch watch = new Stopwatch();
            watch.Start();

            int count = list.Count;
            var fileSessions = new EVENT_TRACE_LOGFILEW[count];
            var handles = new ulong[count];

            for (int i = 0; i < count; ++i)
            {
                unsafe
                {
                    fileSessions[i] = new EVENT_TRACE_LOGFILEW
                    {
                        LogFileName = list[i],
                        EventRecordCallback = deserializer.Deserialize,
                        BufferCallback = deserializer.BufferCallback,
                        LogFileMode = Etw.PROCESS_TRACE_MODE_EVENT_RECORD | Etw.PROCESS_TRACE_MODE_RAW_TIMESTAMP
                    };

                    handles[i] = Etw.OpenTrace(ref fileSessions[i]);
                }
            }

            for (int i = 0; i < handles.Length; ++i)
            {
                unchecked
                {
                    if (handles[i] == (ulong)(~0))
                    {
                        switch (Marshal.GetLastWin32Error())
                        {
                        case 0x57:
                            reportError("ERROR: For file: " + list[i] + " Windows returned 0x57 -- The Logfile parameter is NULL.");
                            return false;
                        case 0xA1:
                            reportError("ERROR: For file: " + list[i] + " Windows returned 0xA1 -- The specified path is invalid.");
                            return false;
                        case 0x5:
                            reportError("ERROR: For file: " + list[i] + " Windows returned 0x5 -- Access is denied.");
                            return false;
                        default:
                            reportError("ERROR: For file: " + list[i] + " Windows returned an unknown error.");
                            return false;
                        }
                    }
                }
            }
            
            jsonWriter.WriteStartObject();
            jsonWriter.WritePropertyName("Events");

            jsonWriter.WriteStartArray();
            Etw.ProcessTrace(handles, (uint)handles.Length, IntPtr.Zero, IntPtr.Zero);
            jsonWriter.WriteEndArray();

            jsonWriter.WriteEndObject();
            
            GC.KeepAlive(fileSessions);

            for (int i = 0; i < count; ++i)
            {
                Etw.CloseTrace(handles[i]);
            }

            return true;
        }

        public static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine(Usage);
                return;
            }

            var commandLineInfo = new CommandLineInfo(args);
            if (!commandLineInfo.Initialize())
            {
                return;
            }

            using var stream = new FileStream(commandLineInfo.Output, FileMode.Create, FileAccess.Write);
            var jsonWriter = new Utf8JsonWriter(stream);

            Stopwatch watch = new Stopwatch();
            watch.Start();

            foreach (var file in commandLineInfo.Inputs)
            {
                Console.WriteLine("Input: " + file);
            }

            Console.WriteLine("Output: " + commandLineInfo.Output);

            bool success = ConvertToJson(jsonWriter, commandLineInfo.Inputs, Console.WriteLine);
            if (!success)
            {
                Console.WriteLine("Error encountered.");
            }
            else
            {
                Console.WriteLine("Finished processing in " + watch.ElapsedMilliseconds + " milliseconds");
            }
        }

        private sealed class CommandLineInfo
        {
            private readonly string[] args;

            public string Output;

            public List<string> Inputs;

            public CommandLineInfo(string[] args)
            {
                this.args = args;
            }

            public bool Initialize()
            {
                bool outputSet = false;
                this.Inputs = new List<string>();
                foreach (var arg in this.args)
                {
                    if (arg.StartsWith("-output") || arg.StartsWith("--output") || arg.StartsWith("/output"))
                    {
                        var s = arg.Split('=');
                        if (s.Length < 2)
                        {
                            Console.WriteLine("ERROR: Encountered incorrect formatting for output filename");
                            Console.WriteLine(Usage);
                            return false;
                        }
                        else
                        {
                            if (outputSet)
                            {
                                Console.WriteLine("ERROR: Encountered incorrect formatting for output filename");
                                Console.WriteLine(Usage);
                                return false;
                            }

                            outputSet = true;
                            this.Output = s[1];
                        }
                    }
                    else
                    {
                        this.Inputs.Add(arg);
                    }
                }

                if (string.IsNullOrEmpty(this.Output))
                {
                    Console.WriteLine("ERROR: Encountered incorrect formatting for output filename");
                    Console.WriteLine(Usage);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}