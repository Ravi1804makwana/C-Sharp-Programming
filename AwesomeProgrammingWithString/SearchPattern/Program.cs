using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the Text : ");
            var text = Console.ReadLine();
            Console.Write("Please enter the Pattern : ");
            var pattern = Console.ReadLine();
            int count = 0, i=0;
            while(text.IndexOf(pattern,i)!=-1)
            {
                count++;
                i= text.IndexOf(pattern, i)+1;
            }
            Console.WriteLine();
            Console.WriteLine("Number of Occurences of Pattern \""+pattern +"\" in Text \""+text+"\" is "+count+" times.");
            Console.ReadKey();
        }
    }
}
