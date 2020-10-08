using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Person student = new Student();

            //var student = new Student();
            
            //Student student = new Student();

            student.Name = "Ravikumar Makwana";
            student.Age = 20;
            Console.WriteLine(student.ToString());
            
            Console.ReadKey();
        }
    }
}
