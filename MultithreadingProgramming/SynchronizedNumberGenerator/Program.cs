using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizedNumberGenerator
{
    public class NumberGenerator
    {
        public void PrintNumber(int number)
        {
            int limit = number + 10;
            for(int i=number;i<limit;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NumberGenerator numberGenerator = new NumberGenerator();
            Thread thread1 = new Thread(() => numberGenerator.PrintNumber(1));
            Thread thread2 = new Thread(() => numberGenerator.PrintNumber(11));
            Thread thread3 = new Thread(() => numberGenerator.PrintNumber(21));
            Thread thread4 = new Thread(() => numberGenerator.PrintNumber(31));
            Thread thread5 = new Thread(() => numberGenerator.PrintNumber(41));
            thread1.Start();
            thread1.Join();
            thread2.Start();
            thread2.Join();
            thread3.Start();
            thread3.Join();
            thread4.Start();
            thread4.Join();
            thread5.Start();
            Console.ReadKey();
        }
    }
}
