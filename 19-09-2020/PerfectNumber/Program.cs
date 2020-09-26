using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumber
{
    class Program
    {
        public static bool Perfect(int n)
        {
            int number = n;
            int sum = 0;
            for(int i=1;i<n;i++)
            {
                if (n % i == 0) sum += i;
            }
            if (sum == number)
                return true;
            else
                return false;
        }
        public static List<int> ListOfPerectNumbers(int limit)
        {
            List<int> perfectNumbers = new List<int>();
            for(int i=1;i<limit;i++)
            {
                int sum = 0;
                for(int j=1;j<i;j++)
                {
                    if (i % j == 0)
                        sum += j;
                }
                if (sum == i)
                    perfectNumbers.Add(i);
            }
            return perfectNumbers;
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter the number : ");
            int n = int.Parse(Console.ReadLine());
            if (Perfect(n))
                Console.WriteLine("Given number is Perfect");
            else
                Console.WriteLine("Given Number is Not Perfect");
            Console.WriteLine();
            Console.Write("Perfect Number is upto : ");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(String.Join(", ",ListOfPerectNumbers(limit)));
            Console.ReadKey();
            Console.Beep();
            Console.ReadKey();

        }
    }
}
