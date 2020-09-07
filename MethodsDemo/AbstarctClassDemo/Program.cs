using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctClassDemo
{
    public class A
    {
        public virtual  void Show()
        {
            Console.WriteLine("Class A");
        }
    }
    public class B : A
    {
        public override void Show()
        {
            Console.WriteLine("Class B");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle();
            rectangle.Draw();

            var circle = new Circle();
            circle.Draw();

            Console.ReadKey();
        }
    }
}
