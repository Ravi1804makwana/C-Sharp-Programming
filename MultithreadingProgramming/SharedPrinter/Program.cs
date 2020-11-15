using System;
using System.Threading;

namespace SharedPrinter
{
    class SharedPrinter
    {
        public void PrintDocument(string text)
        {
            lock (this)
            {
                Console.WriteLine("User : " + Thread.CurrentThread.Name);
                Console.Write("[ ");
                Thread.Sleep(1000);
                Console.Write(text);
                Thread.Sleep(1000);
                Console.Write(" ]");
                Console.WriteLine("\nPrint Successful !!!!!\n");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SharedPrinter printer = new SharedPrinter();
            Thread user1 = new Thread(() => printer.PrintDocument("Document 1"));
            user1.Name = "User 1";
            Thread user2 = new Thread(() => printer.PrintDocument("Document 2"));
            user2.Name = "User 2";
            Thread user3 = new Thread(() => printer.PrintDocument("Document 3"));
            user3.Name = "User 3";
            Thread user4 = new Thread(() => printer.PrintDocument("Document 4"));
            user4.Name = "User 4";
            Thread user5 = new Thread(() => printer.PrintDocument("Document 5"));
            user5.Name = "User 5";
            Thread user6 = new Thread(() => printer.PrintDocument("Document 6"));
            user6.Name = "User 6";
            Thread user7 = new Thread(() => printer.PrintDocument("Document 7"));
            user7.Name = "User 7";

            user1.Start();
            user2.Start();
            user3.Start();
            user4.Start();
            user5.Start();
            user6.Start();
            user7.Start();
            Console.ReadKey();
        }
    }
}
