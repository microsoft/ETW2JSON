namespace ETWDeserializer
{
    public sealed class PropertyMetadata
    {
        internal PropertyMetadata(TDH_IN_TYPE inType, TDH_OUT_TYPE outType, string name, bool isMapValue, bool isStruct, int childrenCount, MapInformation map)
        {
            this.InType = inType;
            this.OutType = outType;
            this.Name = name;
            this.IsMapValue = isMapValue;
            this.IsStruct = isStruct;
            this.ChildrenCount = childrenCount;
            this.Map = map;
        }

        public TDH_IN_TYPE InType { get; private set; }

        public TDH_OUT_TYPE OutType { get; private set; }

        public bool IsMapValue { get; private set; }

        public bool IsStruct { get; private set; }

        public int ChildrenCount { get; private set; }

        public MapInformation Map { get; private set; }

        public string Name { get; private set; }
    }
}