using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace SortingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the numbers : ");
            var line = Console.ReadLine();
            var parts = line.Split(' ');
            var numbers = new int[10];
            for(int i=0;i<line.Split(' ').Length;i++)
                numbers[i] = int.Parse(parts[i]);
            SortNumber(numbers);
            for(int i=0;i<numbers.Length;i++)
                Console.Write(numbers[i]+" ");
            Console.ReadKey();
        }
        public static void SortNumber(int [] numbers)
        {
            int n = numbers.Length;
            for(int i=0;i<n-1;i++)
            {
                for(int j=i+1;j<n;j++)
                {
                    if(numbers[i]>numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
        }
    }
}
