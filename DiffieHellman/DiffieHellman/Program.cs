using System;

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
                        DHAlgorithm.DHKeyExchange(p,g,a,b);
                        break;

                    case 2:
                        Console.Write("Please enter the prime number(p) : ");
                        p = int.Parse(Console.ReadLine());
                        Console.Write("Please enter the Secret Key of Alice(a) : ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Please enter the Secret Key of Bob(b) : ");
                        b = int.Parse(Console.ReadLine());
                        g = DHAlgorithm.GetPrimitiveRoot(p);
                        DHAlgorithm.DHKeyExchange(p, g, a, b);
                        break;

                    case 3:
                        Console.Write("Please enter the prime number : ");
                        p = int.Parse(Console.ReadLine());
                        a = DHAlgorithm.GetSecretKey(1, 100000);
                        b = DHAlgorithm.GetSecretKey(1, 10000);
                        g = DHAlgorithm.GetPrimitiveRoot(p);
                        DHAlgorithm.DHKeyExchange(p, g, a, b);
                        break;

                    case 4:
                        Console.Write("Please enter the prime number : ") ;
                        p = int.Parse(Console.ReadLine());
                        Console.Write("\nAll Possible Primitive Roots of {0} : ",p);
                        var primitiveRoots = DHAlgorithm.GetAllPrimitiveRoots(p);
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
