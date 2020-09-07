using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Please enter the Text : ");
            String text =Console.ReadLine();
            Console.Write("Please enter the String that you need to search in Text : ") ;
            String searchString = Console.ReadLine();
            int i = 0;
            int count = 0;
            while(text.IndexOf(searchString,i)!=-1)
            {
                i = text.IndexOf(searchString, i);
                i++;
                count ++;
                Console.WriteLine("Found At : "+i);
            }
            Console.WriteLine("Total Number of Occureance : "+count);
            Console.ReadKey();
        }
    }
}
