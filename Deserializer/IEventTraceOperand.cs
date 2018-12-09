namespace ETWDeserializer
{
    using System.Collections.Generic;

    public interface IEventTraceOperand
    {
        EventMetadata Metadata { get; }

        IEnumerable<IEventTracePropertyOperand> EventPropertyOperands { get; }
    }
}