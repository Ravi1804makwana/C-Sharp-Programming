using System.Collections.Generic;

namespace NumberSerises
{
    class ArmstrongClass
    {
        public static bool IsArmstrongNumber(int number)
        {
            int temp = number;
            int sum = 0;
            while(temp>0)
            {
                int a = temp % 10;
                sum += a * a * a;
                temp /= 10;
            }
            if (sum == number)
                return true;
            else
                return false; 
        }
        public static List<int> PrimeNumbers(int number)
        {
            var primeNumber = new List<int>();
            for(int i=1;i<number;i++)
            {
                int temp = i;
                int sum = 0;
                while (temp > 0)
                {
                    int a = temp % 10;
                    sum += a * a * a;
                    temp /= 10;
                }
                if (i == sum)
                    primeNumber.Add(i);
            }
            return primeNumber;
        }
    }
}
