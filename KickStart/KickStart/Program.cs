using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KickStart
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int t=1;t<=T;t++)
            {
                var line = Console.ReadLine();
                var parts = line.Split(' ');
                int n = int.Parse(parts[0]);
                int x = int.Parse(parts[1]);
                var arr = new List<int>();
                line = Console.ReadLine();
                var part = line.Split(' ');
                for(int i=0;i<n;i++)
                    arr.Add(int.Parse(part[i]));
                var finallAns = new List<int>();
                int max = arr.Max();
                for(int j=0;j<max/x+10;j++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        arr[i] = arr[i] - x;
                        if (arr[i] <= 0)
                        {
                            if (!finallAns.Contains(i+1))
                                finallAns.Add(i + 1);
                        }
                    }
                }
                Console.WriteLine("Case #{0}:" +
                    " {1}",t,String.Join(" ",finallAns));
            }
        }
    }
}
