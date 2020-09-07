using System.Collections.Generic;

namespace NumberSerises
{
    class PrimeClass
    {
        public static List<int> PrimeNumbers(int number)
        {
            List<int> primeNumbers = new List<int>();
            int c = 0;
            for (int i = 2; i < number; i++)
            {
                c = 1;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        c = 0;
                        break;
                    }
                }
                if (c == 1)
                    primeNumbers.Add(i);
            }
            return primeNumbers;
        }
    }
}
