using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 15;
            var arr = new int[] { a,b };
            Console.WriteLine("a = {0}, b = {1}",arr[0],arr[1]);
            swap(arr);
            Console.WriteLine("a = {0}, b = {1}", arr[0], arr[1]);
            Console.ReadKey();
        }
        public static void swap(int[] arr)
        {
            int temp = arr[0];
            arr[0] = arr[1];
            arr[1] = temp;
        }
    }
}
