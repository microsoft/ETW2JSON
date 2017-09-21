namespace ETWDeserializer
{
    using System.Collections.Generic;

    internal sealed class EventTraceOperand : IEventTraceOperand
    {
        internal EventTraceOperand(EventMetadata metadata, int eventMetadataTableIndex, IEnumerable<IEventTracePropertyOperand> operands)
        {
            this.Metadata = metadata;
            this.EventMetadataTableIndex = eventMetadataTableIndex;
            this.EventPropertyOperands = operands;
        }

        public int EventMetadataTableIndex { get; }

        public EventMetadata Metadata { get; }

        public IEnumerable<IEventTracePropertyOperand> EventPropertyOperands { get; }
    }
}