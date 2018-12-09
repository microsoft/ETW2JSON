namespace ETWDeserializer
{
    using System;

    public interface IEtwWriter
    {
        void WriteEventBegin(string eventName, EventRecordReader runtimeMetadata);

        void WriteEventEnd();

        void WriteStructBegin();

        void WriteStructEnd();

        void WritePropertyBegin(PropertyMetadata metadata);

        void WritePropertyEnd();

        void WriteArrayBegin();

        void WriteArrayEnd();

        void WriteAnsiString(string value);

        void WriteUnicodeString(string value);

        void WriteInt8(sbyte value);

        void WriteUInt8(byte value);

        void WriteInt16(short value);

        void WriteUInt16(ushort value);

        void WriteInt32(int value);

        void WriteUInt32(uint value);

        void WriteInt64(long value);

        void WriteUInt64(ulong value);

        void WriteFloat(float value);

        void WriteDouble(double value);

        void WriteBoolean(bool value);

        void WriteBinary(byte[] value);

        void WriteGuid(Guid value);

        void WritePointer(ulong value);

        void WriteFileTime(DateTime value);

        void WriteSystemTime(DateTime value);

        void WriteSid(string value);

        void WriteUnicodeChar(char value);

        void WriteAnsiChar(char value);

        void WriteHexDump(byte[] value);

        void WriteWbemSid(string value);
    }
}