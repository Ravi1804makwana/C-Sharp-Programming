using System;
using System.Threading;

namespace MultithreadingProgramming
{
    public class NumberGenerater
    {
        public static void PrintNumber(int number)
        {
            int limit = number + 10;
            for(int i=number;i<limit;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }
    }
}
