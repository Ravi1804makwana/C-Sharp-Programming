using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var methodOverLoading = new MethodOverLoading();
            methodOverLoading.add(1,2);
            methodOverLoading.add(1,2,3);
            methodOverLoading.add(1,2,3,4);
            methodOverLoading.add(1,2,3,4,5);
            Console.WriteLine();

            var childClass = new ChildClass();
            childClass.Show();

            A reference;
            var a = new A();
            var b = new B();
            var c = new C();

            reference = a;
            reference.Show();

            reference = b;
            reference.Show();

            reference=c;
            reference.Show();
            

            Console.ReadKey();
        }
    }
}
