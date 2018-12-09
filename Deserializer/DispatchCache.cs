namespace ETWDeserializer
{
    using System;

    public sealed class DispatchCache<T>
    {
        public string EventName { get; set; }

        public PropertyMetadata[] Properties { get; set; }

        public Action<EventRecordReader, T, string, PropertyMetadata[]> Action { get; set; }
    }
}