namespace ETWDeserializer
{
    using System;

    internal struct TraceEventKey : IEquatable<TraceEventKey>
    {
        private readonly Guid providerId;

        private readonly ushort id;

        private readonly byte version;

        public TraceEventKey(Guid providerId, ushort id, byte version)
        {
            this.providerId = providerId;
            this.id = id;
            this.version = version;
        }

        public bool Equals(TraceEventKey other)
        {
            return this.providerId.Equals(other.providerId) && this.id == other.id && this.version == other.version;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is TraceEventKey && this.Equals((TraceEventKey)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = this.providerId.GetHashCode();
                hashCode = (hashCode * 397) ^ this.id.GetHashCode();
                hashCode = (hashCode * 397) ^ this.version.GetHashCode();
                return hashCode;
            }
        }
    }
}