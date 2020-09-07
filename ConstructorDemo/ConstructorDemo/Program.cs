using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product(1,"Redmi 5",3,34,101010);
            product.display();
            Product.displayStatic();

            //Object Initializer work only when member of class are public.
            Person p1 = new Person {
                FirstName = "Ravikumar",
                LastName = "Makwana"
            };
            Console.WriteLine("Hello, {0} {1}",p1.FirstName,p1.LastName);

            var calc = new Calculator();
            calc.Add(new int[] { 1, 2, 3, 4, 5 });
            calc.Add(1, 2, 3, 4, 5 );
            Console.ReadKey();
        }
    }
}
