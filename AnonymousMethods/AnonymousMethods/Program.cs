using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{
    public delegate void Calculator(int number);
    class Calculation
    {
        public static int Number = 10;
        public static void Add(int number)
        {
            Number += number;
            Console.WriteLine("Addition : "+Number);
        }
        public static void Sub(int number)
        {
            Number -= number;
            Console.WriteLine("Subtraction : " + Number);
        }
        public static void Mul(int number)
        {
            Number *= number;
            Console.WriteLine("Multiplication : " + Number);
        }
        public static void Div(int number)
        {
            Number /= number;
            Console.WriteLine("Division : " + Number);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = delegate (int x)
              {
                  Console.WriteLine("Anonymous Method : "+x);
              };

            // It's Call Anonymous method
            calculator(5);

            Console.WriteLine();

            Console.WriteLine("Initial Value : "+Calculation.Number);
            calculator = Calculation.Add;
            calculator(10);

            Console.WriteLine();

            Console.WriteLine("Current Value : " + Calculation.Number);
            calculator = Calculation.Sub;
            calculator(10);

            Console.WriteLine();

            Console.WriteLine("Current Value : " + Calculation.Number);
            calculator = Calculation.Mul;
            calculator(5);

            Console.WriteLine();

            Console.WriteLine("Current Value : " + Calculation.Number);
            calculator = Calculation.Div;
            calculator(2);


            Console.ReadKey();
        }
    }
}
