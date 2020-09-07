using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the some text :");
            String text = Console.ReadLine();
            Console.WriteLine("Reverse String : " + ReverseString(text)) ;
            Console.ReadKey();
        }
        public static String ReverseString(String text)
        {
            var parts = text.Split(' ');
            var reverseString = "";
            for(int i=parts.Length-1;i>=0;i--)
            {
                reverseString += parts[i]+" ";
            }
            return reverseString;
        }
    }
}
