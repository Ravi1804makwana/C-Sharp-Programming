using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace GeneralProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter the a :");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Enter the b :");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("Enter the c :");
            //int c = int.Parse(Console.ReadLine());
            //String result = (a > b) ? (a>c) ? ("A is Big") : ("C is Big") : (b>c)?("B is Big"):("C is Big");
            //Console.WriteLine(result);
            //int count = 0;
            //for(int i=1;i<100;i++)
            //{
            //    if(i%3==0)
            //    {
            //        Console.Write(i+" ");
            //        count++;
            //    }
            //}
            //Console.WriteLine("\nTotal Count : "+count);

            //int sum = 0;
            //while(true)
            //{
            //    String number = Console.ReadLine();
            //    if (number.ToLower()=="ok")
            //        break;
            //    else
            //        sum += int.Parse(number);
            //}
            //Console.WriteLine("Total Sum = {0}",sum);

            //Console.Write("Enter the number : ");
            //int result = Factorial(int.Parse(Console.ReadLine()));
            //Console.WriteLine("Factorial : {0}",result);

            //Console.Write("Please enter the base: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("Please enter the expoinent: ");
            //int e = int.Parse(Console.ReadLine());
            //Console.WriteLine(b+" ^ "+e+" = "+Power(b,e));

            //var random = new Random();
            //int v = random.Next(1,10);
            //int c = 4;
            //bool ans = false;
            //while(c>0)
            //{
            //    int n = int.Parse(Console.ReadLine());
            //    if (n == v)
            //    {
            //        ans = true;
            //        break;
            //    }
            //    else if (n < v)
            //        Console.WriteLine("To Small");
            //    else
            //        Console.WriteLine("To Large");
            //    c--;
            //}
            //if(ans)
            //    Console.WriteLine("YOU WOM");
            //else
            //    Console.WriteLine("YOU LOST");
            //String numbers = Console.ReadLine();
            //int large = 0;
            //var number = numbers.Split(',');
            //foreach (var n in number)
            //{
            //    if (large < int.Parse(n))
            //        large = int.Parse(n);
            //}
            //Console.WriteLine(large);

            //String totalLikes = Console.ReadLine();
            //var parts = totalLikes.Split(',');
            //if(parts.Length==0)
            //    Console.WriteLine("No Likes");
            //else if(parts.Length==1)
            //    Console.WriteLine("[ "+parts[0]+" ] like your Post");
            //else if(parts.Length==2)
            //    Console.WriteLine("[ " + parts[0] + " ] and [ "+parts[1]+ "] like your Post");
            //else
            //    Console.WriteLine("[ " + parts[0] + " ], [ " + parts[1] + "] and other "+(parts.Length-2)+" like your Post");

            //var numbers = new List<int>();
            //while(true)
            //{
            //    var number = Console.ReadLine();
            //    if (number == "Exit")
            //        break;
            //    else
            //    {
            //        int n = int.Parse(number);
            //        if (!numbers.Contains(n))
            //            numbers.Add(n);
            //    }
            //}
            //Console.WriteLine(String.Join(", ",numbers));

            //while(true)
            //{
            //    String line = Console.ReadLine();
            //    var parts = line.Split(',');
            //    if(parts.Length<5)
            //    {
            //        Console.WriteLine("Invalid, Re-Try");
            //        continue;
            //    }
            //    var numbers = new List<int>();
            //    foreach (var n in parts)
            //    {
            //        if(!numbers.Contains(int.Parse(n)))
            //            numbers.Add(int.Parse(n));
            //    }
            //    numbers.Sort();
            //    Console.WriteLine(numbers[0]+", "+numbers[1] + " & "+numbers[2]);
            //    break;
            //}

            //String line = Console.ReadLine();
            //var parts = line.Split('-');
            //bool ans = true;
            //for(int i=0;i<parts.Length-1;i++)
            //{
            //    if(int.Parse(parts[i])+1 !=int.Parse(parts[i+1]))
            //    {
            //        ans = false;
            //        break;
            //    }
            //}
            //if(ans)
            //    Console.WriteLine("Consecutive");
            //else
            //    Console.WriteLine("Not Consecutive");

            //String line = Console.ReadLine();
            //var parts = line.Split('-');
            //bool repeat = true;
            //var result = new List<int>();

            //if(parts.Length==0)
            //    Environment.Exit(0);
            //else
            //{
            //    for (int i = 0; i < parts.Length; i++)
            //    {
            //        int number = int.Parse(parts[i]);
            //        if (!result.Contains(number))
            //            result.Add(number);
            //        else
            //        {
            //            repeat = false;
            //            break;
            //        }
            //    }
            //}
            //if(repeat)
            //    Console.WriteLine("No Duplicate");
            //else
            //    Console.WriteLine("Duplicate");

            //var line = Console.ReadLine();
            //var parts = line.Split(':');
            //int hour = int.Parse(parts[0]);
            //int minute = int.Parse(parts[1]);
            //if(hour>=0 && hour<=23 && minute>=0 && minute<=59 )
            //    Console.WriteLine("Valid Time");
            //else
            //    Console.WriteLine("Invalid Time");
            //var line = Console.ReadLine();
            //var parts = line.ToLower().Split(' ');
            //string result = "";
            //foreach (var part in parts)
            //{
            //    var firstChar = part[0].ToString().ToUpper();
            //    var word = part.Substring(1).ToLower();
            //    result += firstChar + word;
            //}
            //Console.WriteLine(result);

            var line = Console.ReadLine();
            int count = 0;
            for(int i=0;i<line.Length;i++)
            {
                if (line[i] == 'a' || line[i] == 'e' || line[i] == 'i' || line[i] == 'o' || line[i] == 'u')
                    count++;
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
        //public static int Power(int b,int e)
        //{
        //    if (e == 0)
        //        return 1;
        //    else
        //        return b * Power(b, e - 1);
        //}
        //public static int Factorial(int n)
        //{
        //    if (n == 1)
        //        return 1;
        //    else
        //        return n*Factorial(n-1);
        //}
    }
}
