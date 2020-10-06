using System;
using System.Text.RegularExpressions;

namespace RegexExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Validation of name(name must be characters)

            Console.Write("Please enter the FullName: (firstname lastname): ");
            string fullname = Console.ReadLine();
            while (!Regex.IsMatch(fullname, "^[A-Za-z]+[ ][a-zA-Z]+$"))
            {
                Console.WriteLine("Try again: ");
                fullname = Console.ReadLine();
            }

            //Validation of Phone no.(Phone no start with 9 or 8 or 7 or 6 and maximux 10 to 11 digits)
            Console.Write("Please enter the your phone no: ");
            string phoneno = Console.ReadLine();
            while (!Regex.IsMatch(phoneno, "^[9|8|7|6][0-9]{9,10}$"))
            {
                Console.WriteLine("Try again: ");
                phoneno = Console.ReadLine();
            }

            //Email address validation: (Start with lower/upper/digits and must have one @ and more than one dots.)
            Console.Write("Please enter the your email address : ");
            string email = Console.ReadLine();
            while (!Regex.IsMatch(email, "^[0-9a-zA-Z][a-zA-Z0-9._]*@[0-9a-zA-Z].[0-9a-zA-Z_.]+$"))
            {
                Console.WriteLine("Try Again : ");
                email = Console.ReadLine();
            }


            string ipAddresspattern = "^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?).(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?).(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?).(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            string ipAddress = Console.ReadLine();
            while (!Regex.IsMatch(ipAddress, ipAddresspattern))
            {
                Console.WriteLine("Try Again : ");
                ipAddress = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
