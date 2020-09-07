using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var name1 = "Ravi";
            var name = "Ravi";
            var name2 = new String(name.ToCharArray());

            Console.WriteLine(name2=="RaviMakwana");
            
            Console.Write("Please enter the String : ");
            String str = Console.ReadLine();
            var parts = str.Split(' ');
            parts[parts.Length - 2] = parts[parts.Length - 2].ToUpper();
            Console.WriteLine(String.Join(" ",parts));*/

            var fullName = "Ravikumar Makwana";
            Console.WriteLine("Full Name : "+fullName);
            Console.WriteLine("Uppercase : "+fullName.ToUpper());
            Console.WriteLine("Lowercase : "+fullName.ToLower());
            Console.WriteLine("Contains \'kumar\' : "+fullName.Contains("kumar"));
            Console.WriteLine("Size of Full Name : "+fullName.Length);
            Console.WriteLine("Split by blank Space : "+fullName.Split(' ')[1].ToLower().Replace("makwana","Blacksmith Makwana"));
            Console.ReadKey();

        }
    }
}
