using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<Int32>();
            while(true)
            {
                Console.Write("Enter the number ('Quit for exit') : ");
                var number = Console.ReadLine();
                if(number.ToLower().Equals("quit"))
                    break;
                numbers.Add(Convert.ToInt32(number));
            }
            Console.WriteLine("Entered Numbers : ") ;
            Console.WriteLine(String.Join(", ",FindUniqueNumbers(numbers)));
            Console.ReadKey();
        }
        public static List<int> FindUniqueNumbers(List <int> numbers)
        {
            List<int> uniqe = new List<int>();
            foreach (var number in numbers)
            {
                if(!uniqe.Contains(number))
                {
                    uniqe.Add(number);
                }
            }
            return uniqe;
        }
    }
}
