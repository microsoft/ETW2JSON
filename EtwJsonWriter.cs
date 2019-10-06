namespace ETW2JSON
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text.Json;
    using ETWDeserializer;

    public struct EtwJsonWriter : IEtwWriter
    {
        private readonly Utf8JsonWriter writer;

        public EtwJsonWriter(Utf8JsonWriter writer)
        {
            this.writer = writer;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void WriteEventBegin(EventMetadata metadata, RuntimeEventMetadata runtimeMetadata)
        {
            this.writer.WriteStartObject();
            this.writer.WritePropertyName("Event");
            this.writer.WriteStartObject();

            this.writer.WritePropertyName("Timestamp");
            this.writer.WriteNumberValue(runtimeMetadata.Timestamp);

            this.writer.WritePropertyName("ProviderGuid");
            this.writer.WriteStringValue(metadata.ProviderGuid.ToString("D"));

            this.writer.WritePropertyName("Id");
            this.writer.WriteNumberValue(metadata.Id);

            this.writer.WritePropertyName("Version");
            this.writer.WriteNumberValue(metadata.Version);

            this.writer.WritePropertyName("ProcessId");
            this.writer.WriteNumberValue(runtimeMetadata.ProcessId);

            this.writer.WritePropertyName("ThreadId");
            this.writer.WriteNumberValue(runtimeMetadata.ThreadId);

            this.writer.WritePropertyName("ProcessorNumber");
            this.writer.WriteNumberValue(runtimeMetadata.ProcessorNumber);

            var activityId = runtimeMetadata.ActivityId;
            if (activityId != Guid.Empty)
            {
                this.writer.WritePropertyName("ActivityId");
                this.writer.WriteStringValue(activityId.ToString("D"));
            }

            var relatedActivityId = runtimeMetadata.RelatedActivityId;
            if (relatedActivityId != Guid.Empty)
            {
                this.writer.WritePropertyName("RelatedActivityId");
                this.writer.WriteStringValue(relatedActivityId.ToString("D"));
            }

            var stacks = runtimeMetadata.GetStacks(out var matchId);
            if (matchId != 0)
            {
                this.writer.WritePropertyName("StackMatchId");
                this.writer.WriteNumberValue(matchId);
            }

            if (stacks != null)
            {
                this.writer.WritePropertyName("Stacks");
                this.writer.WriteStartArray();
                for (int i = 0; i < stacks.Length; ++i)
                {
                    this.writer.WriteNumberValue(stacks[i]);
                }
                this.writer.WriteEndArray();
            }
            
            this.writer.WritePropertyName("Name");
            this.writer.WriteStringValue(metadata.Name);
            
            this.writer.WritePropertyName("Properties");
            this.writer.WriteStartArray();
            this.writer.WriteStartObject();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteEventEnd()
        {
            this.writer.WriteEndObject();
            this.writer.WriteEndArray();
            this.writer.WriteEndObject();
            this.writer.WriteEndObject();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteStructBegin()
        {
            this.writer.WriteStartObject();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteStructEnd()
        {
            this.writer.WriteEndObject();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WritePropertyBegin(PropertyMetadata metadata)
        {
            this.writer.WritePropertyName(metadata.Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WritePropertyEnd()
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteArrayBegin()
        {
            this.writer.WriteStartArray();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteArrayEnd()
        {
            this.writer.WriteEndArray();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteAnsiString(string value)
        {
            this.writer.WriteStringValue(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUnicodeString(string value)
        {
            this.writer.WriteStringValue(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteInt8(sbyte value)
        {
            this.writer.WriteNumberValue(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUInt8(byte value)
        {
            this.writer.WriteNumberValue(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteInt16(short value)
        {
            this.writer.WriteNumberValue(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUInt16(ushort value)
        {
            this.writer.WriteNumberValue(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteInt32(int value)
        {
            this.writer.WriteNumberValue(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUInt32(uint value)
        {
            this.writer.WriteNumberValue(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteInt64(long value)
        {
            this.writer.WriteNumberValue(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUInt64(ulong value)
        {
            this.writer.WriteNumberValue(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteFloat(float value)
        {
            this.writer.WriteNumberValue(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteDouble(double value)
        {
            this.writer.WriteNumberValue(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBoolean(bool value)
        {
            this.writer.WriteBooleanValue(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBinary(byte[] value)
        {
            this.writer.WriteBase64StringValue(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteGuid(Guid value)
        {
            this.writer.WriteStringValue(value.ToString("D"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WritePointer(ulong value)
        {
            this.writer.WriteNumberValue(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteFileTime(DateTime value)
        {
            this.writer.WriteStringValue(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSystemTime(DateTime value)
        {
            this.writer.WriteStringValue(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSid(string value)
        {
            this.writer.WriteStringValue(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUnicodeChar(char value)
        {
            this.writer.WriteNumberValue(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteAnsiChar(char value)
        {
            this.writer.WriteNumberValue(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteHexDump(byte[] value)
        {
            this.writer.WriteBase64StringValue(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteWbemSid(string value)
        {
            this.writer.WriteStringValue(value);
        }
    }
}