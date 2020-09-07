using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class Numbers
    {
        private String []name=new string[5];
        public String this[int index]
        {
            get
            {
                return name[index];
            }
            set
            {
                name[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var groups = new Numbers();
            groups[0] = "One";
            groups[1] = "Two";
            groups[2] = "Three";
            groups[3] = "Four";
            groups[4] = "Five";
            Console.WriteLine(groups[0]);
            Console.WriteLine(groups[1]);
            Console.WriteLine(groups[2]);
            Console.WriteLine(groups[3]);
            Console.WriteLine(groups[4]);
            Console.ReadKey();
        }
    }
}
