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
            // Word start with S or s
            // \b is use for must before s we have blank space Therefore starting with S or s
            // and last \S non space characters.
            ShowMatch(line, @"\b[S|s]\S*");

            // Remove Extra Spaces in two words
            string line1 = Console.ReadLine();
            Regex regex = new Regex("\\s+");
            Console.WriteLine(regex.Replace(line1, " "));


            string text = "<h1>Hello</h1> <p>How are you?</p> <h2>I am Fine</h2>";
            ShowMatch(text, @"[<]\S*[>][a-zA-Z0-9 ?\b]*[<]/\S*[>]");

            string myText = "ravi Ravi Makwana kumar Ravi";
            ShowMatch(myText, @"(ravi)|(Ravi)");


            //string statring with a or A and ending with z or Z
            string myText1 = "Az ABBBCz aaaa aza bZa aCCz aCCZ";
            ShowMatch(myText1,@"\b(A|a)\S*(Z|z)\b");
            Console.ReadKey();
        }
    }
}
