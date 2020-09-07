using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student();
            student1.firstName = "Ravikumar";
            student1.lastName = "Makwana";
            student1.age = 18;
            student1.Show();
            Console.WriteLine();
            var student2 = new Student("Ravikumar", "Makwana",18);
            student2.Show();
            Console.ReadKey();
        }
    }
}
