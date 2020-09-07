using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 1, 2, 3 };
            foreach (var a in A)
                Console.Write(a+" ");

            Console.WriteLine();
            
            int[] B = new int[3]{ 1, 2, 3 };
            foreach (var b in B)
                Console.Write(b + " ");

            Console.WriteLine();

            var C = new int[] { 1, 2, 3 };
            foreach (var c in C)
                Console.Write(c+" ");

            Console.WriteLine();
            var D = new int[5,5];
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<5;j++)
                {
                    Console.Write("["+i+","+j+"] ");
                }
                Console.WriteLine();
            }

            var E = new int[3][];
            E[0] = new int[5];
            E[0][0] = 0;
            E[0][1] = 1;
            E[0][2] = 2;
            E[0][3] = 3;
            E[0][4] = 4;

            E[1] = new int[2];
            E[1][1] = 11;
            E[1][0] = 22;

            E[2] = new int[4];
            E[2][0] = 1;
            E[2][1] = 1;
            E[2][2] = 1;
            E[2][3] = 1;
            
            for(int i=0;i<5;i++)
                Console.Write(E[0][i]+" ");

            Console.WriteLine();

            for (int i = 0; i < 2; i++)
                Console.Write(E[0][i] + " ");

            Console.WriteLine();

            for (int i = 0; i < 4; i++)
                Console.Write(E[0][i] + " ");

            Console.ReadKey();
        }
    }
}
