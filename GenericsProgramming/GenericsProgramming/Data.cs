namespace GenericsProgramming
{
    public class Data<T>//Generic Class 
    {
        private T Id;//Generic Fields
        public Data(T id)//Generic Constructor
        {
            this.Id = id;
        }
        
        public T MyProperty//Generic Property
        {
            set { Id = value; }
            get { return Id;  }
        }
    }
}
