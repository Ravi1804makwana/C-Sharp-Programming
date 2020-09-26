using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CodeVita
{
    class Program
    {
        static int count;

        public static void Show()
        {
            Console.WriteLine("Static Value : "+count);
        }

        static void Main(string[] args)
        {
            Show();
            Console.ReadKey();
        }
    }
}
