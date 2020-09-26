using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_09_2020
{
    class Program
    {
        public static int AdditionOfArray(params int [] array)
        {
            int sum = 0;
            foreach (var number in array) sum += number;
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Addition up to 1 .. 10 : " + AdditionOfArray(1,2,3,4,5,6,7,8,9,10));
            Console.WriteLine("Addition up to 1 .. 10 : " + AdditionOfArray(new int[] { 1,2,3,4,5,6,7,8,9,10}));
            Console.ReadKey();
        }
    }
}
