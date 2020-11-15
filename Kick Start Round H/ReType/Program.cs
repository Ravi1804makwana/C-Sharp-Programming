using System;

namespace ReType
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int t=1;t<=T;t++)
            {
                int N, K, S;
                var line = Console.ReadLine();
                var parts = line.Split(' ');
                N = int.Parse(parts[0]);
                K = int.Parse(parts[1]);
                S = int.Parse(parts[2]);

                int diff = K - S;
                if (diff > S)
                {
                    if(S!=1)
                        K = K + 2 * S + 1 + (N - K);
                    else
                        K = K + 2 * S + (N - K);
                }
                else
                    K = K + 2 * diff + (N - K);

                Console.WriteLine("Case #"+t+": "+ K);
            }
            Console.ReadKey();
        }
    }
}
