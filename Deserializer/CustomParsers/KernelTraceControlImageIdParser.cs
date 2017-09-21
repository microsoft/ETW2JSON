namespace ETWDeserializer.CustomParsers
{
    using System;

    internal sealed class KernelTraceControlImageIdParser
    {
        private static readonly EventMetadata EventMetadata;

        private static readonly PropertyMetadata ImageBase;

        private static readonly PropertyMetadata ImageSize;

        private static readonly PropertyMetadata TimeDateStamp;

        private static readonly PropertyMetadata OriginalFileName;

        static KernelTraceControlImageIdParser()
        {
            ImageBase = new PropertyMetadata(TDH_IN_TYPE.TDH_INTYPE_POINTER, TDH_OUT_TYPE.TDH_OUTTYPE_HEXINT64, "ImageBase", false, false, 0, null);
            ImageSize = new PropertyMetadata(TDH_IN_TYPE.TDH_INTYPE_UINT32, TDH_OUT_TYPE.TDH_OUTTYPE_UNSIGNEDINT, "ImageSize", false, false, 0, null);
            TimeDateStamp = new PropertyMetadata(TDH_IN_TYPE.TDH_INTYPE_UINT32, TDH_OUT_TYPE.TDH_OUTTYPE_UNSIGNEDINT, "TimeDateStamp", false, false, 0, null);
            OriginalFileName = new PropertyMetadata(TDH_IN_TYPE.TDH_INTYPE_UNICODESTRING, TDH_OUT_TYPE.TDH_OUTTYPE_STRING, "OriginalFileName", false, false, 0, null);
            EventMetadata = new EventMetadata(
                new Guid("b3e675d7-2554-4f18-830b-2762732560de"),
                36,
                0,
                "KernelTraceControl/ImageID",
                new[] { ImageBase, ImageSize, TimeDateStamp, OriginalFileName, });
        }

        public void Parse<T>(EventRecordReader reader, T writer, EventMetadata[] metadataArray, RuntimeEventMetadata runtimeMetadata)
            where T : IEtwWriter
        {
            writer.WriteEventBegin(EventMetadata, runtimeMetadata);

            writer.WritePropertyBegin(ImageBase);
            writer.WritePointer(reader.ReadPointer());
            writer.WritePropertyEnd();

            writer.WritePropertyBegin(ImageSize);
            writer.WriteUInt32(reader.ReadUInt32());
            writer.WritePropertyEnd();

            reader.ReadPointer();

            writer.WritePropertyBegin(TimeDateStamp);
            writer.WriteUInt32(reader.ReadUInt32());
            writer.WritePropertyEnd();

            writer.WritePropertyBegin(OriginalFileName);
            writer.WriteUnicodeString(reader.ReadUnicodeString());
            writer.WritePropertyEnd();

            writer.WriteEventEnd();
        }
    }
}