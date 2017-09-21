namespace ETWDeserializer
{
    using System.Collections.Generic;

    public sealed class MapInformation
    {
        private readonly Dictionary<uint, string> mapOfValues;

        internal MapInformation(string name, Dictionary<uint, string> mapOfValues)
        {
            this.Name = name;
            this.mapOfValues = mapOfValues;
        }

        public string Name { get; private set; }

        public string this[uint i] => this.mapOfValues[i];
    }
}