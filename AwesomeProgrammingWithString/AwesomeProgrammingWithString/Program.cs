using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToggleText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the text: ");
            string line = Console.ReadLine();
            for(int i=0;i<line.Length;i++)
            {
                if(line[i]>='a' && line[i]<='z')
                    Console.Write((char)(line[i]-32));
                else if (line[i] >= 'A' && line[i] <= 'Z')
                    Console.Write((char)(line[i] + 32));
                else
                    Console.Write(line[i]);
            }
            Console.ReadKey();
        }
    }
}
