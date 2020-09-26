using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    class A
    {
        public A()
        {
            Console.WriteLine("Class A");
        }
    }
    class B:A
    {
        public B()
        {
            Console.WriteLine("Class B");
        }
    }
    class C:B
    {
        public C()
        {
            Console.WriteLine("Class C");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var c = new C();
            Console.ReadKey();
        }
    }
}
