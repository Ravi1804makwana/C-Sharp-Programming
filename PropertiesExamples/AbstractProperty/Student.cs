namespace AbstractProperty
{
    class Student : Person
    {
        private string _name;
        private int _age;
        public override string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public override int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        // By default every class derived from Object Class
        public override string ToString()
        {
            return _name + " : " + _age;
        }
    }
}
