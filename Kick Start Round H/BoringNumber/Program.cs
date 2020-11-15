using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoringNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int t=1;t<=T;t++)
            {
                int count = 0;
                var parts = Console.ReadLine().Split(' ');
                int lower = int.Parse(parts[0]);
                int upper = int.Parse(parts[1]);

                for(int i=lower;i<=upper;i++)
                {
                    bool isBoring = true;
                    string number = i.ToString();
                    for(int j=0;j<number.Length;j++)
                    {
                        if(j%2!=0 || j!=0)
                        {
                            if(int.Parse(number[j].ToString())%2!=0)
                            {
                                isBoring = false;
                                break;
                            }
                        }
                        else
                        {
                            if (int.Parse(number[j].ToString()) % 2 == 0)
                            {
                                isBoring = false;
                                break;
                            }
                        }
                    }

                    if (isBoring)
                        count++;
                }
                Console.WriteLine("Case #" + t + ": " + count);
            }
            Console.ReadKey();
        }
    }
}
