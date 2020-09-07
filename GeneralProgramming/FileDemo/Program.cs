using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new StreamReader("G:/All Semester important Data/Importantent Notes/Ip Regex.txt");
            Console.WriteLine(file.ReadToEnd());
            Console.ReadKey();
        }
    }
}
