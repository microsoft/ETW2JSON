namespace ETWDeserializer
{
    using System.Collections.Generic;

    internal sealed class EventTracePropertyOperand : IEventTracePropertyOperand
    {
        public EventTracePropertyOperand(PropertyMetadata metadata, int propertyIndex, bool isVariableArray, bool isFixedArray, bool isVariableLength, bool isFixedLength, bool isWbemXml)
        {
            this.Metadata = metadata;
            this.PropertyIndex = propertyIndex;
            this.IsVariableArray = isVariableArray;
            this.IsFixedArray = isFixedArray;
            this.IsVariableLength = isVariableLength;
            this.IsFixedLength = isFixedLength;
            this.IsWbemXMLFragment = isWbemXml;
            this.Children = new List<IEventTracePropertyOperand>();
        }

        public PropertyMetadata Metadata { get; }

        public int PropertyIndex { get; }

        public bool IsVariableArray { get; }

        public IEventTracePropertyOperand VariableArraySize { get; private set; }

        public bool IsVariableLength { get; }

        public IEventTracePropertyOperand VariableLengthSize { get; private set; }

        public bool IsFixedArray { get; }

        public int FixedArraySize { get; private set; }

        public bool IsFixedLength { get; }

        public int FixedLengthSize { get; private set; }

        public bool IsWbemXMLFragment { get; }

        public bool IsReferencedByOtherProperties { get; set; }

        public List<IEventTracePropertyOperand> Children { get; }

        public void SetFixedArraySize(int fixedArraySize)
        {
            this.FixedArraySize = fixedArraySize;
        }

        public void SetVariableArraySize(IEventTracePropertyOperand reference)
        {
            this.VariableArraySize = reference;
        }

        public void SetFixedLengthSize(int fixedLengthSize)
        {
            this.FixedLengthSize = fixedLengthSize;
        }

        public void SetVariableLengthSize(IEventTracePropertyOperand reference)
        {
            this.VariableLengthSize = reference;
        }
    }
}