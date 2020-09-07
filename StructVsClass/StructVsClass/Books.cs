using System;

namespace StructVsClass
{
    public struct Books
    {
        public String Title,Author,Publication;
        public double Price;
        public Books(String Title,String  Author, String Publication,double Price)
        {
            this.Title = Title;
            this.Author = Author;
            this.Publication = Publication;
            this.Price = Price;
        }
        public void Display()
        {
            Console.WriteLine("Book Title : "+Title);
            Console.WriteLine("Book Author : " + Author);
            Console.WriteLine("Book Publication : " + Publication);
            Console.WriteLine("Book Price : " + Price);
        }
    }
}
