namespace _24_09_2020
{
    class PropertyDemo
    {
        private int c;
            
        public int ReadOnly
        {
            get { return c; }
        }
        public int WriteOnly
        {
            set{ c = value; }
        }
        public int ReadWrite
        {
            set { c = value; }
            get { return c; }
        }
    }
}
