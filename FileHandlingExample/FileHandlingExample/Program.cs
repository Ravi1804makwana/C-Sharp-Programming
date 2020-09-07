using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "G:/Start Journey/index.php";
            //var content=File.ReadAllText("G:/Start Journey/index.php");
            //Console.WriteLine(content);

            var fileInfo = new FileInfo(path);
            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.Extension);
            Console.WriteLine(fileInfo.Length);
            Console.WriteLine(fileInfo.DirectoryName);
            Console.WriteLine(fileInfo.Exists);
            Console.WriteLine();
            Console.WriteLine();

            var fileDirectory = Directory.GetFiles("G:/Start Journey","*.php");
            foreach (var file in fileDirectory)
            {
                Console.WriteLine(file+"\n");
            }
            Console.ReadKey();
        }
    }
}
