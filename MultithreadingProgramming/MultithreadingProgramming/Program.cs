using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(() => NumberGenerater.PrintNumber(1));
            Thread thread2 = new Thread(() => NumberGenerater.PrintNumber(11));
            Thread thread3 = new Thread(() => NumberGenerater.PrintNumber(21));
            Thread thread4 = new Thread(() => NumberGenerater.PrintNumber(31));
            Thread thread5 = new Thread(() => NumberGenerater.PrintNumber(41));
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();
            Console.ReadKey();
        }
    }
}
