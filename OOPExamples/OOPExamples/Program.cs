using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new B(1,2);
            b.ShowA();
            b.ShowB();

            Console.WriteLine();
            var child = new ChildClass();
            var child2 = new ChildClass("Hello World");
            Console.ReadKey();
        }
    }
}
