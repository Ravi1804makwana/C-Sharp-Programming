using System;
using System.Collections.Generic;

namespace DiffieHellman
{
    class Program
    {
        /*
         *  Author : Ravikumar Makwana
         *  Aim : Implementation of Diffie Hellman Key Exchange Algorithm
         *  
         *  DHKeyExchange() : Actual Logic of Algorithm 
         *  GetSecretKey()  : To generate random key
         *  FastExponent()  : To calculate exponent of large values
         *  GetAllPrimitiveRoots() : To generate all possible primitive roots.
         *  GetPrimitiveRoot() : Randomly get one primitive root.
         */
        public static int GetSecretKey(int min,int max)
        {
            var random = new Random();
            return random.Next(min, max);
        }
        public static int FastExponent(int g,int a,int p)
        {
            //initial result = g ^ 1
            int result = g;

            var binary = Convert.ToString(a,2);
            for(int i=1;i<binary.Length;i++)
            {
                if(binary[i]=='1')
                {
                    result = (result * result) % p;
                    result = (result * g) % p;
                }
                else
                {
                    result = (result * result) % p;
                }
            }
           return result;
        }
        public static void DHKeyExchange(int p,int g,int a,int b)
        {
            Console.WriteLine("\nDiffie Hellman Key Algorithm (p, g, a, b) : ({0},{1},{2},{3})",p,g,a,b);
            Console.WriteLine("\nPrivate Key of Alice : {0}",a);
            Console.WriteLine("Private Key of Bob : {0}", b);

            //Calcualte Public Key of Alice
            int A = FastExponent(g,a,p);
            Console.WriteLine("\nPublic Key of Alice(A) : "+A);

            //Calcualte Public Key of Bob
            int B = FastExponent(g,b,p);
            Console.WriteLine("Public Key of Bob(B) : " + B);

            //Exchange Key between Alice and Bob

            //Calculate Shared Secret Key at Alice Side
            int Kab = FastExponent(B, a, p);
            Console.WriteLine("\nShared Secret Key at Alice Side : "+Kab);

            //Calculate Shared Secret Key at Bob Side
            int Kba = FastExponent(A, b, p);
            Console.WriteLine("Shared Secret Key at Bob Side : " + Kba);
        }
        public static List<int> GetAllPrimitiveRoots(int p)
        {
            // Initial Set
            var set = new List<int>();
            for (int i = 1; i < p; i++)
                set.Add(i);

            var primitiveRoots = new List<int>();

            for(int i=0;i<p-1;i++)
            {
                int number = set[i];
                var orderSet = new List<int>();

                for(int j=1;j<p;j++)
                    orderSet.Add(FastExponent(number, j, p));
                orderSet.Sort();
                var same = true;
                for(int j=0;j<p-1;j++)
                {
                    if(set[j]!=orderSet[j])
                    {
                        same = false;
                        break;
                    }
                }
                // If Order of orderSet and set are same, than and than it is primitive root
                if (same)
                    primitiveRoots.Add(number);
            }
            
            return primitiveRoots;
        }
        public static int GetPrimitiveRoot(int p)
        {
            //Get All Primitive Roots
            var primitiveRoots = GetAllPrimitiveRoots(p);
            
            //Select One root from Set of roots
            var randome = new Random();

            return primitiveRoots[randome.Next(0, primitiveRoots.Count)];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Diffie Hellman Key Exchange Algorithm\n");

            while (true)
            {
                // Get Choice from User.
                Console.WriteLine("Case #1: Enter the all the values like p, g, a and b");
                Console.WriteLine("Case #2: Enter only prime number(p) and Secrect Key of Alice(a) and Bob(b)");
                Console.WriteLine("Case #3: Enter only prime Number(p) ");
                Console.WriteLine("Case #4: Generate All Primitive Roots");
                Console.WriteLine("Case #5: Exit\n");
                
                Console.Write("Please enter the Choice : ");
                int choice = int.Parse(Console.ReadLine());
                
                int p, g, a, b;

                switch (choice)
                {
                    case 1:
                        Console.Write("Please enter the prime number(p) : ");
                        p = int.Parse(Console.ReadLine());
                        Console.Write("Please enter the generator(g) : ");
                        g = int.Parse(Console.ReadLine());
                        Console.Write("Please enter the Secret Key of Alice(a) : ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Please enter the Secret Key of Bob(b) : ");
                        b = int.Parse(Console.ReadLine());
                        DHKeyExchange(p,g,a,b);
                        break;

                    case 2:
                        Console.Write("Please enter the prime number(p) : ");
                        p = int.Parse(Console.ReadLine());
                        Console.Write("Please enter the Secret Key of Alice(a) : ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Please enter the Secret Key of Bob(b) : ");
                        b = int.Parse(Console.ReadLine());
                        g = GetPrimitiveRoot(p);
                        DHKeyExchange(p, g, a, b);
                        break;

                    case 3:
                        Console.Write("Please enter the prime number : ");
                        p = int.Parse(Console.ReadLine());
                        a = GetSecretKey(1, 100000);
                        b = GetSecretKey(1, 10000);
                        g = GetPrimitiveRoot(p);
                        DHKeyExchange(p, g, a, b);
                        break;

                    case 4:
                        Console.Write("Please enter the prime number : ") ;
                        p = int.Parse(Console.ReadLine());
                        Console.Write("\nAll Possible Primitive Roots of {0} : ",p);
                        var primitiveRoots = GetAllPrimitiveRoots(p);
                        foreach (var roots in primitiveRoots)
                        {
                            Console.Write(roots+" ");
                        }
                        Console.WriteLine();
                        break;
                    
                    case 5: Environment.Exit(0); 
                        break;

                    default:
                        Console.WriteLine("Please enter the rigth Choice : ");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
