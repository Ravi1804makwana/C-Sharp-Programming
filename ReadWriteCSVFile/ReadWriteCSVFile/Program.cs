using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteCSVFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.GetData();
            foreach (var studnet in p.students)
            {
                var person = studnet;
                Console.WriteLine(person.Name+", "+person.Age);
            }
            Console.WriteLine("Enter the Idnex");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Please enter the name: ");
            p.students[i].Name = Console.ReadLine();
            Console.Write("Please enter the age: ");
            p.students[i].Age = int.Parse(Console.ReadLine());
            
            p.PutData();
            Console.ReadKey();
        }
    }
}
