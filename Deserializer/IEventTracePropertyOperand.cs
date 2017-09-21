namespace ETWDeserializer
{
    using System.Collections.Generic;

    public interface IEventTracePropertyOperand
    {
        PropertyMetadata Metadata { get; }

        int PropertyIndex { get; }

        bool IsVariableArray { get; }

        IEventTracePropertyOperand VariableArraySize { get; }

        bool IsVariableLength { get; }

        IEventTracePropertyOperand VariableLengthSize { get; }

        bool IsFixedArray { get; }

        int FixedArraySize { get; }

        bool IsFixedLength { get; }

        int FixedLengthSize { get; }

        bool IsWbemXMLFragment { get; }

        bool IsReferencedByOtherProperties { get; }

        List<IEventTracePropertyOperand> Children { get; }
    }
}