using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(int number);
    class MyClass
    {
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
        public void Method3()
        {
            Console.WriteLine("Method 3");
        }
        public void Method4()
        {
            Console.WriteLine("Method 4");
        }
        public void Method1(int n)
        {
            Console.WriteLine("Method 1: "+n);
        }
        public void Method2(int n)
        {
            Console.WriteLine("Method 2: " + n);
        }
        public void Method3(int n)
        {
            Console.WriteLine("Method 3: " + n);
        }
        public void Method4(int n)
        {
            Console.WriteLine("Method 4: " + n);
        }

        public static void One()
        {
            Console.WriteLine("One");
        }
        public static void Two()
        {
            Console.WriteLine("Two");
        }
        public static void Three()
        {
            Console.WriteLine("Three");
        }
        public static void Four()
        {
            Console.WriteLine("Four");
        }
        public static void Five()
        {
            Console.WriteLine("Five");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyDelegate myDelegate = new MyDelegate(myClass.Method1);
            myDelegate();
            myDelegate = myClass.Method2;
            myDelegate();
            myDelegate = myClass.Method3;
            myDelegate();
            myDelegate = myClass.Method4;
            myDelegate();

            Console.WriteLine();

            MyDelegate2 myDelegate2 = new MyDelegate2(myClass.Method1);
            myDelegate2(11);
            myDelegate2 = myClass.Method2;
            myDelegate2(22);
            myDelegate2 = myClass.Method3;
            myDelegate2(33);
            myDelegate2 = myClass.Method4;
            myDelegate2(44);

            Console.WriteLine();

            MyDelegate myDelegate1 = new MyDelegate(myClass.Method1);
            myDelegate1 += myClass.Method2;
            myDelegate1 += myClass.Method3;
            myDelegate1 += myClass.Method4;
            myDelegate1();

            Console.WriteLine();

            MyDelegate2 myDelegate3 = new MyDelegate2(myClass.Method1);
            myDelegate3 += myClass.Method2;
            myDelegate3 += myClass.Method3;
            myDelegate3 += myClass.Method4;
            myDelegate3(10);

            Console.WriteLine();

            MyDelegate multcase = new MyDelegate(MyClass.One);
            multcase += MyClass.Two;
            multcase += MyClass.Three;
            multcase += MyClass.Four;
            multcase += MyClass.Five;
            multcase();

            Console.ReadKey();
        }
    }
}
