using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexExample1
{
    class Program
    {
        public static void ShowMatch(String text, String pattern)
        {
            MatchCollection matchCollection = Regex.Matches(text, pattern);
            foreach (var m in matchCollection)
            {
                Console.WriteLine(m);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the line:");
            string line = Console.ReadLine();
            // Word start with S
            ShowMatch(line,@"\bS\S*");

            // Word start with S
            ShowMatch(line, @"\bA\S*Z\b");

            // Remove Extra Spaces in two words
            string line1 = Console.ReadLine();
            Regex regex = new Regex("\\s+");
            Console.WriteLine(regex.Replace(line1," "));
            Console.ReadKey();
        }
    }
}
