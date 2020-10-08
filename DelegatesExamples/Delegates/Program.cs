using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate(string message);
    class Program
    {
        public static void ConsoleOutput(string messsage)
        {
            Console.WriteLine("Write in Console : "+messsage);
        }
        public static void FileOutput(string message)
        {
            Console.WriteLine("Write in File : " + message);
        }
        public static void DatabaseOutput(string message)
        {
            Console.WriteLine("Write in Database : " + message);
        }
        public static void SendMessage(MyDelegate myDelegate)
        {
            myDelegate("Hello World!");
        }
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(ConsoleOutput);
            SendMessage(myDelegate);

            myDelegate = FileOutput;
            SendMessage(myDelegate);

            myDelegate = DatabaseOutput;
            SendMessage(myDelegate);

            Console.ReadKey();
        }
    }
}
