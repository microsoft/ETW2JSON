namespace ETWDeserializer
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Reflection;

    internal static class Extensions
    {
        public static void AddOrUpdate<K, V>(this Dictionary<K, V> dict, K k, V v)
        {
            if (dict.ContainsKey(k))
            {
                dict[k] = v;
            }
            else
            {
                dict.Add(k, v);
            }
        }

        public static TDH_IN_TYPE ToTdhInType(string value)
        {
            value = value.ToLowerInvariant();
            switch (value)
            {
                case "unicodestring":
                    return TDH_IN_TYPE.TDH_INTYPE_UNICODESTRING;
                case "ansistring":
                    return TDH_IN_TYPE.TDH_INTYPE_ANSISTRING;
                case "int8":
                    return TDH_IN_TYPE.TDH_INTYPE_INT8;
                case "uint8":
                    return TDH_IN_TYPE.TDH_INTYPE_UINT8;
                case "int16":
                    return TDH_IN_TYPE.TDH_INTYPE_INT16;
                case "uint16":
                    return TDH_IN_TYPE.TDH_INTYPE_UINT16;
                case "int32":
                    return TDH_IN_TYPE.TDH_INTYPE_INT32;
                case "uint32":
                    return TDH_IN_TYPE.TDH_INTYPE_UINT32;
                case "int64":
                    return TDH_IN_TYPE.TDH_INTYPE_INT64;
                case "uint64":
                    return TDH_IN_TYPE.TDH_INTYPE_UINT64;
                case "float":
                    return TDH_IN_TYPE.TDH_INTYPE_FLOAT;
                case "double":
                    return TDH_IN_TYPE.TDH_INTYPE_DOUBLE;
                case "boolean":
                    return TDH_IN_TYPE.TDH_INTYPE_BOOLEAN;
                case "binary":
                    return TDH_IN_TYPE.TDH_INTYPE_BINARY;
                case "guid":
                    return TDH_IN_TYPE.TDH_INTYPE_GUID;
                case "sizet":
                case "pointer":
                    return TDH_IN_TYPE.TDH_INTYPE_POINTER;
                case "filetime":
                    return TDH_IN_TYPE.TDH_INTYPE_FILETIME;
                case "systemtime":
                    return TDH_IN_TYPE.TDH_INTYPE_SYSTEMTIME;
                case "sid":
                    return TDH_IN_TYPE.TDH_INTYPE_SID;
                case "hextint32":
                    return TDH_IN_TYPE.TDH_INTYPE_HEXINT32;
                case "hexint64":
                    return TDH_IN_TYPE.TDH_INTYPE_HEXINT64;
                default:
                    throw new Exception("Unreachable");
            }
        }

        public static Expression SizeOF(this TDH_IN_TYPE tdhType)
        {
            switch (tdhType)
            {
                case TDH_IN_TYPE.TDH_INTYPE_UNICODESTRING:
                    return Expression.Constant(0); // size check happens inside his reader
                case TDH_IN_TYPE.TDH_INTYPE_ANSISTRING:
                    return Expression.Constant(0); // size check happens inside his reader
                case TDH_IN_TYPE.TDH_INTYPE_INT8:
                    return Expression.Constant(sizeof(sbyte));
                case TDH_IN_TYPE.TDH_INTYPE_UINT8:
                    return Expression.Constant(sizeof(byte));
                case TDH_IN_TYPE.TDH_INTYPE_INT16:
                    return Expression.Constant(sizeof(short));
                case TDH_IN_TYPE.TDH_INTYPE_UINT16:
                    return Expression.Constant(sizeof(ushort));
                case TDH_IN_TYPE.TDH_INTYPE_INT32:
                    return Expression.Constant(sizeof(int));
                case TDH_IN_TYPE.TDH_INTYPE_UINT32:
                    return Expression.Constant(sizeof(uint));
                case TDH_IN_TYPE.TDH_INTYPE_INT64:
                    return Expression.Constant(sizeof(long));
                case TDH_IN_TYPE.TDH_INTYPE_UINT64:
                    return Expression.Constant(sizeof(ulong));
                case TDH_IN_TYPE.TDH_INTYPE_FLOAT:
                    return Expression.Constant(sizeof(float));
                case TDH_IN_TYPE.TDH_INTYPE_DOUBLE:
                    return Expression.Constant(sizeof(double));
                case TDH_IN_TYPE.TDH_INTYPE_BOOLEAN:
                    return Expression.Constant(4); // this is because in Windows we have bools as ints
                case TDH_IN_TYPE.TDH_INTYPE_BINARY:
                    return Expression.Constant(0); // size check happens inside his reader
                case TDH_IN_TYPE.TDH_INTYPE_GUID:
                    return Expression.Constant(16); // otherwise requires unsafe
                case TDH_IN_TYPE.TDH_INTYPE_POINTER:
                    return Expression.Constant(4); // TODO: FIXME with conditional
                case TDH_IN_TYPE.TDH_INTYPE_FILETIME:
                    return Expression.Constant(16); // Windows
                case TDH_IN_TYPE.TDH_INTYPE_SYSTEMTIME:
                    return Expression.Constant(16); // Windows
                case TDH_IN_TYPE.TDH_INTYPE_SID:
                    return Expression.Constant(0); // size check happens inside his reader
                case TDH_IN_TYPE.TDH_INTYPE_HEXINT32:
                    return Expression.Constant(sizeof(int));
                case TDH_IN_TYPE.TDH_INTYPE_HEXINT64:
                    return Expression.Constant(sizeof(long));
                case TDH_IN_TYPE.TDH_INTYPE_COUNTEDSTRING:
                    return Expression.Constant(0); // size check happens inside his reader
                case TDH_IN_TYPE.TDH_INTYPE_COUNTEDANSISTRING:
                    return Expression.Constant(0); // size check happens inside his reader
                case TDH_IN_TYPE.TDH_INTYPE_REVERSEDCOUNTEDSTRING:
                    return Expression.Constant(0); // size check happens inside his reader
                case TDH_IN_TYPE.TDH_INTYPE_REVERSEDCOUNTEDANSISTRING:
                    return Expression.Constant(0); // size check happens inside his reader
                case TDH_IN_TYPE.TDH_INTYPE_NONNULLTERMINATEDSTRING:
                    return Expression.Constant(0); // size check happens inside his reader
                case TDH_IN_TYPE.TDH_INTYPE_NONNULLTERMINATEDANSISTRING:
                    return Expression.Constant(0); // size check happens inside his reader
                case TDH_IN_TYPE.TDH_INTYPE_UNICODECHAR:
                    return Expression.Constant(sizeof(char));
                case TDH_IN_TYPE.TDH_INTYPE_ANSICHAR:
                    return Expression.Constant(sizeof(byte));
                case TDH_IN_TYPE.TDH_INTYPE_SIZET:
                    return Expression.Constant(4); // TODO: FIXME with conditional
                case TDH_IN_TYPE.TDH_INTYPE_HEXDUMP:
                    return Expression.Constant(0); // size check happens inside his reader
                case TDH_IN_TYPE.TDH_INTYPE_WBEMSID:
                    return Expression.Constant(0); // size check happens inside his reader
                default:
                    throw new Exception("Unreachable");
            }
        }

        public static Type CSharpType(this TDH_IN_TYPE tdhType)
        {
            switch (tdhType)
            {
                case TDH_IN_TYPE.TDH_INTYPE_UNICODESTRING:
                    return typeof(string);
                case TDH_IN_TYPE.TDH_INTYPE_ANSISTRING:
                    return typeof(string);
                case TDH_IN_TYPE.TDH_INTYPE_INT8:
                    return typeof(sbyte);
                case TDH_IN_TYPE.TDH_INTYPE_UINT8:
                    return typeof(byte);
                case TDH_IN_TYPE.TDH_INTYPE_INT16:
                    return typeof(short);
                case TDH_IN_TYPE.TDH_INTYPE_UINT16:
                    return typeof(ushort);
                case TDH_IN_TYPE.TDH_INTYPE_INT32:
                    return typeof(int);
                case TDH_IN_TYPE.TDH_INTYPE_UINT32:
                    return typeof(uint);
                case TDH_IN_TYPE.TDH_INTYPE_INT64:
                    return typeof(long);
                case TDH_IN_TYPE.TDH_INTYPE_UINT64:
                    return typeof(ulong);
                case TDH_IN_TYPE.TDH_INTYPE_FLOAT:
                    return typeof(float);
                case TDH_IN_TYPE.TDH_INTYPE_DOUBLE:
                    return typeof(double);
                case TDH_IN_TYPE.TDH_INTYPE_BOOLEAN:
                    return typeof(bool);
                case TDH_IN_TYPE.TDH_INTYPE_BINARY:
                    return typeof(byte[]);
                case TDH_IN_TYPE.TDH_INTYPE_GUID:
                    return typeof(Guid);
                case TDH_IN_TYPE.TDH_INTYPE_POINTER:
                    return typeof(ulong);
                case TDH_IN_TYPE.TDH_INTYPE_FILETIME:
                    return typeof(DateTime);
                case TDH_IN_TYPE.TDH_INTYPE_SYSTEMTIME:
                    return typeof(DateTime);
                case TDH_IN_TYPE.TDH_INTYPE_SID:
                    return typeof(string);
                case TDH_IN_TYPE.TDH_INTYPE_HEXINT32:
                    return typeof(int);
                case TDH_IN_TYPE.TDH_INTYPE_HEXINT64:
                    return typeof(long);
                case TDH_IN_TYPE.TDH_INTYPE_COUNTEDSTRING:
                    return typeof(string);
                case TDH_IN_TYPE.TDH_INTYPE_COUNTEDANSISTRING:
                    return typeof(string);
                case TDH_IN_TYPE.TDH_INTYPE_REVERSEDCOUNTEDSTRING:
                    return typeof(string);
                case TDH_IN_TYPE.TDH_INTYPE_REVERSEDCOUNTEDANSISTRING:
                    return typeof(string);
                case TDH_IN_TYPE.TDH_INTYPE_NONNULLTERMINATEDSTRING:
                    return typeof(string);
                case TDH_IN_TYPE.TDH_INTYPE_NONNULLTERMINATEDANSISTRING:
                    return typeof(string);
                case TDH_IN_TYPE.TDH_INTYPE_UNICODECHAR:
                    return typeof(char);
                case TDH_IN_TYPE.TDH_INTYPE_ANSICHAR:
                    return typeof(char);
                case TDH_IN_TYPE.TDH_INTYPE_SIZET:
                    return typeof(ulong);
                case TDH_IN_TYPE.TDH_INTYPE_HEXDUMP:
                    return typeof(byte[]);
                case TDH_IN_TYPE.TDH_INTYPE_WBEMSID:
                    return typeof(string);
                default:
                    throw new Exception("Unreachable");
            }
        }

        public static MethodInfo ReadMethodInfo(this TDH_IN_TYPE tdhType, Type type, params Type[] parameterType)
        {
            switch (tdhType)
            {
                case TDH_IN_TYPE.TDH_INTYPE_UNICODESTRING:
                    return GetMethodInfo(type, "ReadUnicodeString", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_ANSISTRING:
                    return GetMethodInfo(type, "ReadAnsiString", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_INT8:
                    return GetMethodInfo(type, "ReadInt8", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_UINT8:
                    return GetMethodInfo(type, "ReadUInt8", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_INT16:
                    return GetMethodInfo(type, "ReadInt16", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_UINT16:
                    return GetMethodInfo(type, "ReadUInt16", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_INT32:
                    return GetMethodInfo(type, "ReadInt32", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_UINT32:
                    return GetMethodInfo(type, "ReadUInt32", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_INT64:
                    return GetMethodInfo(type, "ReadInt64", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_UINT64:
                    return GetMethodInfo(type, "ReadUInt64", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_FLOAT:
                    return GetMethodInfo(type, "ReadFloat", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_DOUBLE:
                    return GetMethodInfo(type, "ReadDouble", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_BOOLEAN:
                    return GetMethodInfo(type, "ReadBoolean", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_BINARY:
                    return GetMethodInfo(type, "ReadBinary", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_GUID:
                    return GetMethodInfo(type, "ReadGuid", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_POINTER:
                    return GetMethodInfo(type, "ReadPointer", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_FILETIME:
                    return GetMethodInfo(type, "ReadFileTime", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_SYSTEMTIME:
                    return GetMethodInfo(type, "ReadSystemTime", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_SID:
                    return GetMethodInfo(type, "ReadSid", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_HEXINT32:
                    return GetMethodInfo(type, "ReadInt32", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_HEXINT64:
                    return GetMethodInfo(type, "ReadInt64", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_COUNTEDSTRING:
                    return GetMethodInfo(type, "ReadCountedString", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_COUNTEDANSISTRING:
                    return GetMethodInfo(type, "ReadCountedAnsiString", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_REVERSEDCOUNTEDSTRING:
                    return GetMethodInfo(type, "ReadReversedCountedString", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_REVERSEDCOUNTEDANSISTRING:
                    return GetMethodInfo(type, "ReadReversedCountedAnsiString", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_NONNULLTERMINATEDSTRING:
                    return GetMethodInfo(type, "ReadNonNullTerminatedString", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_NONNULLTERMINATEDANSISTRING:
                    return GetMethodInfo(type, "ReadNonNullTerminatedAnsiString", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_UNICODECHAR:
                    return GetMethodInfo(type, "ReadUnicodeChar", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_ANSICHAR:
                    return GetMethodInfo(type, "ReadAnsiChar", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_SIZET:
                    return GetMethodInfo(type, "ReadPointer", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_HEXDUMP:
                    return GetMethodInfo(type, "ReadHexDump", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_WBEMSID:
                    return GetMethodInfo(type, "ReadWbemSid", parameterType);
                default:
                    throw new Exception("Unreachable");
            }
        }

        public static MethodInfo WriteMethodInfo(this TDH_IN_TYPE tdhType, Type type, params Type[] parameterType)
        {
            switch (tdhType)
            {
                case TDH_IN_TYPE.TDH_INTYPE_UNICODESTRING:
                    return GetMethodInfo(type, "WriteUnicodeString", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_ANSISTRING:
                    return GetMethodInfo(type, "WriteAnsiString", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_INT8:
                    return GetMethodInfo(type, "WriteInt8", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_UINT8:
                    return GetMethodInfo(type, "WriteUInt8", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_INT16:
                    return GetMethodInfo(type, "WriteInt16", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_UINT16:
                    return GetMethodInfo(type, "WriteUInt16", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_INT32:
                    return GetMethodInfo(type, "WriteInt32", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_UINT32:
                    return GetMethodInfo(type, "WriteUInt32", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_INT64:
                    return GetMethodInfo(type, "WriteInt64", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_UINT64:
                    return GetMethodInfo(type, "WriteUInt64", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_FLOAT:
                    return GetMethodInfo(type, "WriteFloat", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_DOUBLE:
                    return GetMethodInfo(type, "WriteDouble", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_BOOLEAN:
                    return GetMethodInfo(type, "WriteBoolean", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_BINARY:
                    return GetMethodInfo(type, "WriteBinary", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_GUID:
                    return GetMethodInfo(type, "WriteGuid", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_POINTER:
                    return GetMethodInfo(type, "WritePointer", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_FILETIME:
                    return GetMethodInfo(type, "WriteFileTime", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_SYSTEMTIME:
                    return GetMethodInfo(type, "WriteSystemTime", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_SID:
                    return GetMethodInfo(type, "WriteSid", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_HEXINT32:
                    return GetMethodInfo(type, "WriteInt32", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_HEXINT64:
                    return GetMethodInfo(type, "WriteInt64", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_COUNTEDSTRING:
                    return GetMethodInfo(type, "WriteUnicodeString", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_COUNTEDANSISTRING:
                    return GetMethodInfo(type, "WriteAnsiString", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_REVERSEDCOUNTEDSTRING:
                    return GetMethodInfo(type, "WriteUnicodeString", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_REVERSEDCOUNTEDANSISTRING:
                    return GetMethodInfo(type, "WriteAnsiString", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_NONNULLTERMINATEDSTRING:
                    return GetMethodInfo(type, "WriteUnicodeString", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_NONNULLTERMINATEDANSISTRING:
                    return GetMethodInfo(type, "WriteAnsiString", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_UNICODECHAR:
                    return GetMethodInfo(type, "WriteUnicodeChar", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_ANSICHAR:
                    return GetMethodInfo(type, "WriteAnsiChar", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_SIZET:
                    return GetMethodInfo(type, "WritePointer", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_HEXDUMP:
                    return GetMethodInfo(type, "WriteBinary", parameterType);
                case TDH_IN_TYPE.TDH_INTYPE_WBEMSID:
                    return GetMethodInfo(type, "WriteSid", parameterType);
                default:
                    throw new Exception("Unreachable");
            }
        }

        private static MethodInfo GetMethodInfo(Type type, string name, params Type[] parameterType)
        {
            return type.GetMethod(name, parameterType);
        }
    }
}