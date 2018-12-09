namespace ETWDeserializer
{
    using System.Collections.Generic;

    internal sealed class EventTraceOperand : IEventTraceOperand
    {
        internal EventTraceOperand(EventMetadata metadata, IEnumerable<IEventTracePropertyOperand> operands)
        {
            this.Metadata = metadata;
            this.EventPropertyOperands = operands;
        }

        public EventMetadata Metadata { get; }

        public IEnumerable<IEventTracePropertyOperand> EventPropertyOperands { get; }
    }
}