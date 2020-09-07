using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSerises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First 10 Prime Numbers " + String.Join(", ", PrimeClass.PrimeNumbers(10)) +"\n");
            Console.Write("First 20 Prime Numbers " + String.Join(", ", PrimeClass.PrimeNumbers(20)) + "\n");
            Console.Write("First 30 Prime Numbers " + String.Join(", ", PrimeClass.PrimeNumbers(30)) + "\n");
            Console.Write("First 40 Prime Numbers " + String.Join(", ", PrimeClass.PrimeNumbers(40)) + "\n");
            Console.Write("First 50 Prime Numbers " + String.Join(", ", PrimeClass.PrimeNumbers(50)) + "\n");
            Console.WriteLine();
            Console.WriteLine("151 is Armstrong number : " + ArmstrongClass.IsArmstrongNumber(151));
            Console.WriteLine("153 is Armstrong number : " + ArmstrongClass.IsArmstrongNumber(153));
            Console.WriteLine();
            Console.WriteLine("Armstrong Number form 1 to 1000 : "+ String.Join(", ",ArmstrongClass.PrimeNumbers(1000)));
            Console.ReadKey();
        }
    }
}
