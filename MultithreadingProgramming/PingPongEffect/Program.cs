using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PingPongEffect
{
    class PingPongEffect
    {
        public void Effect1()
        {
            while (true)
            {
                Console.Write("|");
                Thread.Sleep(100);
            }
        }
        public void Effect2()
        {
            while (true)
            {
                Console.Write("O");
                Thread.Sleep(100);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PingPongEffect effect = new PingPongEffect();
            Thread thread1 = new Thread(new ThreadStart(effect.Effect1));
            Thread thread2 = new Thread(new ThreadStart(effect.Effect2));
            thread1.Start();
            thread2.Start();
        }
    }
}
