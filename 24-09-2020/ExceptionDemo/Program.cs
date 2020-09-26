using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class InvalidOperationExceptionRavi : Exception
    {
        public InvalidOperationExceptionRavi(string message="Invalid Exception") : base(message) { }
    }
    class Program
    {
        public static void MyMethod()
        {
            try
            {
                throw new InvalidOperationExceptionRavi("From Method");
            }
            catch
            {

                Console.WriteLine("Again Throw");
                throw;
            }
        }
        static void Main(string[] args)
        {
            //int a, b, c = 0;
            //try
            //{
            //    var line = Console.ReadLine();
            //    var parts = line.Split(' ');
            //    a = int.Parse(parts[0]);
            //    b = int.Parse(parts[2]);
            //    var op = parts[1];
            //    switch (op)
            //    {
            //        case "+":
            //            c = a + b;
            //            break;

            //        case "-":
            //            c = a - b;
            //            break;

            //        case "*":
            //            c = a * b;
            //            break;

            //        case "/":
            //            c = a / b;
            //            break;

            //        default:
            //            Console.WriteLine("Invalid Operation");
            //            break;

            //    }
            //}
            //catch (FormatException fe)
            //{
            //    Console.WriteLine("FormatException occure ...");
            //}
            //catch (DivideByZeroException dbxe)
            //{
            //    Console.WriteLine("DivideByZeroException occure ...");
            //}
            //catch (NullReferenceException nre)
            //{
            //    Console.WriteLine("NullReferenceException occure ...");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Exception occure ...");
            //}
            //finally
            //{
            //    Console.WriteLine("Finall Answer : " + c);
            //}
            try
            {
                MyMethod();
            }
            catch (InvalidOperationExceptionRavi ioeravi)
            {
                Console.WriteLine("Now Catched");
                Console.WriteLine(ioeravi.Message);
            }
            finally
            {
                Console.WriteLine("Always Execute");
            }
            Console.ReadKey();
        }
    }
}
