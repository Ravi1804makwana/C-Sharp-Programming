using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            String fullname = "Ravikumar Makwana";
            Console.WriteLine("Trim String : "+fullname.Trim());
            Console.WriteLine("ToUpper String : "+fullname.ToUpper());
            Console.WriteLine("ToLower String : " + fullname.ToLower());

            int index = fullname.IndexOf(" ");
            var firstName = fullname.Substring(0, index);
            var lastName = fullname.Substring(index + 1);
            Console.WriteLine("Firstname : "+firstName);
            Console.WriteLine("Lastname : "+lastName);

            var parts = fullname.Split(' ');
            Console.WriteLine("First Part : "+parts[0]);
            Console.WriteLine("Second Part : " + parts[1]);

            Console.WriteLine(fullname+" : "+fullname.Replace("Ravikumar","Ravi"));
            
            if(String.IsNullOrEmpty(""))
                Console.WriteLine("Invalid.");
            else
                Console.WriteLine("Valid");
            
            if (String.IsNullOrEmpty(null))
                Console.WriteLine("Invalid.");
            else
                Console.WriteLine("Valid");
            
            if (String.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("Invalid.");
            else
                Console.WriteLine("Valid");

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid.");
            else
                Console.WriteLine("Valid");

            int number = 1234;
            String myNumber = number.ToString();
            Console.WriteLine(myNumber);

            String myNewNumber = "123456";
            int myNew = Convert.ToInt32(myNewNumber);
            myNew++;
            Console.WriteLine(myNew.ToString("e"));

            Console.ReadKey();
        }
    }
}
