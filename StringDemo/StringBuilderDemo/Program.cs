using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            Console.WriteLine(builder);

            Console.WriteLine();

            builder.Replace('-', '+');
            Console.WriteLine(builder);

            Console.WriteLine();

            builder.Remove(0, 10);
            Console.WriteLine(builder);

            Console.WriteLine();

            builder.Insert(0, new String('+', 10));
            Console.WriteLine(builder);
            Console.WriteLine();

            //I Love you
            var fullname = new StringBuilder();
            fullname.Append("Ravi")
                    .Replace("Ravi", "Ravikumar")
                    .Append(" ")
                    .Append("Makwana");
            Console.WriteLine(fullname);

            Console.ReadKey();
        }
    }
}
