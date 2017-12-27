namespace ETWDeserializer
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security.Principal;

    public struct EventRecordReader
    {
        private readonly unsafe EVENT_RECORD* eventRecord;

        internal unsafe EventRecordReader(EVENT_RECORD* eventRecord)
        {
            this.eventRecord = eventRecord;
        }

        /// <summary>
        /// Reader for TDH_INTYPE_UNICODESTRING
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe string ReadUnicodeString()
        {
            int length = 0;
            byte* ptr = this.eventRecord->UserData;
            long maxLength = this.eventRecord->UserDataLength - (this.eventRecord->UserData - this.eventRecord->UserDataFixed);

            while (!(ptr[length] == 0 && ptr[length + 1] == 0) && length < maxLength)
            {
                ++length;
            }

            string value = new string((char*)this.eventRecord->UserData, 0, (length + 1) / 2);
            this.eventRecord->UserData += (value.Length + 1) * 2; // +2 (via the multiplication)
            return value;
        }

        /// <summary>
        /// Reader for TDH_INTYPE_UNICODESTRING
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ReadUnicodeString(short length)
        {
            return this.ReadUnicodeStringHelper(length);
        }

        /// <summary>
        /// Reader for TDH_INTYPE_UNICODESTRING
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ReadUnicodeString(ushort length)
        {
            return this.ReadUnicodeStringHelper(length);
        }

        /// <summary>
        /// Reader for TDH_INTYPE_UNICODESTRING
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ReadUnicodeString(int length)
        {
            return this.ReadUnicodeStringHelper(length);
        }

        /// <summary>
        /// Reader for TDH_INTYPE_UNICODESTRING
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ReadUnicodeString(uint length)
        {
            return this.ReadUnicodeStringHelper((int)length);
        }

        /// <summary>
        /// Reader for TDH_INTYPE_ANSISTRING
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe string ReadAnsiString()
        {
            int length = 0;
            byte* ptr = this.eventRecord->UserData;
            long maxLength = this.eventRecord->UserDataLength - (this.eventRecord->UserData - this.eventRecord->UserDataFixed);
            while (ptr[length] != 0 && length < maxLength)
            {
                ++length;
            }

            var arr = new char[length];
            for (int i = 0; i < length; ++i)
            {
                arr[i] = (char)*ptr++;
            }

            this.eventRecord->UserData += length + 1; // +1 for null terminator
            return new string(arr);
        }

        /// <summary>
        /// Reader for TDH_INTYPE_ANSISTRING
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ReadAnsiString(short length)
        {
            return this.ReadAnsiStringHelper(length);
        }

        /// <summary>
        /// Reader for TDH_INTYPE_ANSISTRING
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ReadAnsiString(ushort length)
        {
            return this.ReadAnsiStringHelper(length);
        }

        /// <summary>
        /// Reader for TDH_INTYPE_ANSISTRING
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ReadAnsiString(int length)
        {
            return this.ReadAnsiStringHelper(length);
        }

        /// <summary>
        /// Reader for TDH_INTYPE_ANSISTRING
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ReadAnsiString(uint length)
        {
            return this.ReadAnsiStringHelper((int)length);
        }

        /// <summary>
        /// Reader for TDH_INTYPE_INT8
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe sbyte ReadInt8()
        {
            sbyte value = *(sbyte*)this.eventRecord->UserData;
            this.eventRecord->UserData += sizeof(sbyte);
            return value;
        }

        /// <summary>
        /// Reader for TDH_INTYPE_UINT8
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe byte ReadUInt8()
        {
            byte value = *this.eventRecord->UserData;
            this.eventRecord->UserData += sizeof(byte);
            return value;
        }

        /// <summary>
        /// Reader for TDH_INTYPE_INT16
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe short ReadInt16()
        {
            short value = *(short*)this.eventRecord->UserData;
            this.eventRecord->UserData += sizeof(short);
            return value;
        }

        /// <summary>
        /// Reader for TDH_INTYPE_UINT16
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe ushort ReadUInt16()
        {
            ushort value = *(ushort*)this.eventRecord->UserData;
            this.eventRecord->UserData += sizeof(ushort);
            return value;
        }

        /// <summary>
        /// Reader for TDH_INTYPE_INT32
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe int ReadInt32()
        {
            int value = *(int*)this.eventRecord->UserData;
            this.eventRecord->UserData += sizeof(int);
            return value;
        }

        /// <summary>
        /// Reader for TDH_INTYPE_UINT32
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint ReadUInt32()
        {
            uint value = *(uint*)this.eventRecord->UserData;
            this.eventRecord->UserData += sizeof(uint);
            return value;
        }

        /// <summary>
        /// Reader for TDH_INTYPE_INT64
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe long ReadInt64()
        {
            long value = *(long*)this.eventRecord->UserData;
            this.eventRecord->UserData += sizeof(long);
            return value;
        }

        /// <summary>
        /// Reader for TDH_INTYPE_UINT64
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe ulong ReadUInt64()
        {
            ulong value = *(ulong*)this.eventRecord->UserData;
            this.eventRecord->UserData += sizeof(ulong);
            return value;
        }

        /// <summary>
        /// Reader for TDH_INTYPE_FLOAT
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float ReadFloat()
        {
            float value = *(float*)this.eventRecord->UserData;
            this.eventRecord->UserData += sizeof(float);
            return value;
        }

        /// <summary>
        /// Reader for TDH_INTYPE_DOUBLE
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe double ReadDouble()
        {
            double value = *(double*)this.eventRecord->UserData;
            this.eventRecord->UserData += sizeof(double);
            return value;
        }

        /// <summary>
        /// Reader for TDH_INTYPE_BOOLEAN
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool ReadBoolean()
        {
            bool value = *(int*)this.eventRecord->UserData != 0;
            this.eventRecord->UserData += sizeof(int);
            return value;
        }

        /// <summary>
        /// Reader for TDH_INTYPE_BINARY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe byte[] ReadBinary(short size)
        {
            var value = new byte[size];
            Marshal.Copy((IntPtr)this.eventRecord->UserData, value, 0, size);
            this.eventRecord->UserData += size;
            return value;
        }

        /// <summary>
        /// Reader for TDH_INTYPE_BINARY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe byte[] ReadBinary(ushort size)
        {
            var value = new byte[size];
            Marshal.Copy((IntPtr)this.eventRecord->UserData, value, 0, size);
            this.eventRecord->UserData += size;
            return value;
        }

        /// <summary>
        /// Reader for TDH_INTYPE_BINARY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe byte[] ReadBinary(int size)
        {
            var value = new byte[size];
            Marshal.Copy((IntPtr)this.eventRecord->UserData, value, 0, size);
            this.eventRecord->UserData += size;
            return value;
        }

        /// <summary>
        /// Reader for TDH_INTYPE_BINARY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe byte[] ReadBinary(uint size)
        {
            var value = new byte[size];
            Marshal.Copy((IntPtr)this.eventRecord->UserData, value, 0, (int)size);
            this.eventRecord->UserData += size;
            return value;
        }

        /// <summary>
        /// Reader for TDH_INTYPE_GUID
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Guid ReadGuid()
        {
            Guid value = *(Guid*)this.eventRecord->UserData;
            this.eventRecord->UserData += sizeof(Guid);
            return value;
        }

        /// <summary>
        /// Reader for TDH_INTYPE_POINTER
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe ulong ReadPointer()
        {
            if ((eventRecord->Flags & Etw.EVENT_HEADER_FLAG_32_BIT_HEADER) == Etw.EVENT_HEADER_FLAG_32_BIT_HEADER)
            {
                return this.ReadUInt32();
            }

            return this.ReadUInt64();
        }

        /// <summary>
        /// Reader for TDH_INTYPE_FILETIME
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DateTime ReadFileTime()
        {
            return DateTime.FromFileTimeUtc(this.ReadInt64());
        }

        /// <summary>
        /// Reader for TDH_INTYPE_SYSTEMTIME
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DateTime ReadSystemTime()
        {
            int year = this.ReadInt16();
            int month = this.ReadInt16();
            this.ReadInt16();
            int day = this.ReadInt16();
            int hour = this.ReadInt16();
            int minute = this.ReadInt16();
            int second = this.ReadInt16();
            int milliseconds = this.ReadInt16();
            return new DateTime(year, month, day, hour, minute, second, milliseconds);
        }

        /// <summary>
        /// Reader for TDH_INTYPE_SID
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe string ReadSid()
        {
            var value = new SecurityIdentifier((IntPtr)this.eventRecord->UserData);
            this.eventRecord->UserData += value.BinaryLength;
            return value.Value;
        }

        /// <summary>
        /// Reader for TDH_INTYPE_COUNTEDSTRING
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe string ReadCountedString()
        {
            ushort length = this.ReadUInt16();
            return this.ReadUnicodeStringHelper(length);
        }

        /// <summary>
        /// Reader for TDH_INTYPE_COUNTEDANSISTRING
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe string ReadCountedAnsiString()
        {
            ushort length = this.ReadUInt16();
            return this.ReadAnsiStringHelper(length);
        }

        /// <summary>
        /// Reader for TDH_INTYPE_REVERSEDCOUNTEDSTRING
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe string ReadReversedCountedString()
        {
            byte low = this.ReadUInt8();
            byte high = this.ReadUInt8();
            ushort length = (ushort)(((uint)low & 0xFF) | ((uint)high & 0xFF) << 8);

            return this.ReadUnicodeStringHelper(length);
        }

        /// <summary>
        /// Reader for TDH_INTYPE_REVERSEDCOUNTEDANSISTRING
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe string ReadReversedCountedAnsiString()
        {
            byte low = this.ReadUInt8();
            byte high = this.ReadUInt8();
            ushort length = (ushort)(((uint)low & 0xFF) | ((uint)high & 0xFF) << 8);

            return this.ReadAnsiStringHelper(length);
        }

        /// <summary>
        /// Reader for TDH_INTYPE_NONNULLTERMINATEDSTRING
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe string ReadNonNullTerminatedString()
        {
            return this.ReadUnicodeStringHelper(this.eventRecord->UserDataLength);
        }

        /// <summary>
        /// Reader for TDH_INTYPE_NONNULLTERMINATEDANSISTRING
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe string ReadNonNullTerminatedAnsiString()
        {
            return this.ReadAnsiStringHelper(this.eventRecord->UserDataLength);
        }

        /// <summary>
        /// Reader for TDH_INTYPE_UNICODECHAR
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe char ReadUnicodeChar()
        {
            char value = *(char*)this.eventRecord->UserData;
            this.eventRecord->UserData += sizeof(char);
            return value;
        }

        /// <summary>
        /// Reader for TDH_INTYPE_ANSICHAR
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe char ReadAnsiChar()
        {
            char value = (char)*this.eventRecord->UserData;
            this.eventRecord->UserData += 1;
            return value;
        }

        /// <summary>
        /// Reader for TDH_INTYPE_HEXDUMP
        ///
        /// https://msdn.microsoft.com/en-us/library/windows/desktop/aa363800(v=vs.85).aspx
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte[] ReadHexDump()
        {
            return this.ReadBinary(this.ReadInt32());
        }

        /// <summary>
        /// Reader for TDH_INTYPE_WBEMSID
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe string ReadWbemSid()
        {
            int pointerSize = (eventRecord->Flags & Etw.EVENT_HEADER_FLAG_32_BIT_HEADER) == Etw.EVENT_HEADER_FLAG_32_BIT_HEADER ? 4 : 8;
            this.eventRecord->UserData += pointerSize * 2;
            return this.ReadSid();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private unsafe string ReadAnsiStringHelper(int length)
        {
            byte* ptr = this.eventRecord->UserData;
            var arr = new char[length];
            for (int i = 0; i < length; ++i)
            {
                arr[i] = (char)*ptr++;
            }

            this.eventRecord->UserData += length;
            return new string(arr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private unsafe string ReadUnicodeStringHelper(int length)
        {
            string value = new string((char*)this.eventRecord->UserData, 0, length / 2);
            this.eventRecord->UserData += value.Length * 2;
            return value;
        }
    }
}