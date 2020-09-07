using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbers
{
    class Program
    {
        public static void swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void MyMethod(out int a)
        {
            a = 10;
        }
        static void Main(string[] args)
        {
            /* int a = 1;
             int b = 2;
             Console.WriteLine("a = {0}, b = {1}",a,b);
             swap(ref a, ref b);
             Console.WriteLine("a = {0}, b = {1}", a, b);
             MyMethod(out a);
             Console.WriteLine(a);
             */
            ComplexNumber complexNumber1 = new ComplexNumber(1, 2);
            ComplexNumber complexNumber2 = new ComplexNumber(1, 3);
            ComplexNumber complexNumber3 = new ComplexNumber();
            complexNumber3.Add(complexNumber1, complexNumber2);
            ComplexNumber complexNumber4 = new ComplexNumber();
            complexNumber4.Multiply(complexNumber1, complexNumber2);
            Console.Write("Complex Number 1 :");
            complexNumber1.show();
            Console.Write("Complex Number 2 :");
            complexNumber2.show();
            Console.Write("Addition :");
            complexNumber3.show();
            Console.Write("Multiplication :");
            complexNumber4.show();
            Console.ReadKey();
        }
    }
}
