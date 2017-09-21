namespace ETWDeserializer
{
    using System.Collections.Generic;

    public interface IEventTraceOperand
    {
        int EventMetadataTableIndex { get; }

        EventMetadata Metadata { get; }

        IEnumerable<IEventTracePropertyOperand> EventPropertyOperands { get; }
    }
}