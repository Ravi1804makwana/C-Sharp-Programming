using System;
using System.Threading;

namespace TypeWriter
{
    class TypeWriter
    {
        public void WriteText(string text)
        {
            for(int i=0;i<text.Length;i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(100);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TypeWriter typeWriter = new TypeWriter();
            Thread thread = new Thread(()=>typeWriter.WriteText("Ravikumar Makwana"));
            thread.Start();
            Console.ReadKey();
        }
    }
}
