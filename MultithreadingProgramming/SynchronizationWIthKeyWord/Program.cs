using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizationWIthKeyWord
{
    public class NumberGenerator
    {
        public void PrintNumber(int number) 
        {
            lock (this)
            {
                int limit = number + 10;
                for (int i = number; i < limit; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name+" : "+i);
                    Thread.Sleep(500);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NumberGenerator numberGenerator = new NumberGenerator();
            Thread thread1 = new Thread(() => numberGenerator.PrintNumber(1));
            thread1.Name = "Thread 1";
            Thread thread2 = new Thread(() => numberGenerator.PrintNumber(11));
            thread2.Name = "Thread 2";
            Thread thread3 = new Thread(() => numberGenerator.PrintNumber(21));
            thread3.Name = "Thread 3";
            Thread thread4 = new Thread(() => numberGenerator.PrintNumber(31));
            thread4.Name = "Thread 4";
            Thread thread5 = new Thread(() => numberGenerator.PrintNumber(41));
            thread5.Name = "Thread 5";
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();
            Console.ReadKey();
        }
    }
}
