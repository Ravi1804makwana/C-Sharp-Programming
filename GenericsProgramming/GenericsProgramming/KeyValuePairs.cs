namespace GenericsProgramming
{
    public class KeyValuePairs<Tkey, TValue>
    {
        private Tkey Key;
        private TValue Value;

        public KeyValuePairs(Tkey key, TValue value)
        {
            Key = key;
            Value = value;
        }
        public Tkey MyKey
        {
            get { return Key; }
            set { Key = value; }
        }
        public TValue MyValue
        {
            get { return Value; }
            set { Value = value; }
        }
    }
}
