using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExamples
{
    class Indexer
    {
        private string[] _myVariables=new string[5];
        public string this[int index]
        {
            get
            {
                return _myVariables[index];
            }
            set
            {
                _myVariables[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new Indexer();
            myList[0] = "One";
            myList[1] = "Two";
            myList[2] = "Three";
            myList[3] = "Four";
            myList[4] = "Five";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(myList[i]);
            }

            Console.ReadKey();
        }
    }
}
