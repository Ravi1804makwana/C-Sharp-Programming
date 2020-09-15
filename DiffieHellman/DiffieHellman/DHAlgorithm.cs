using System;
using System.Collections.Generic;

namespace DiffieHellman
{
    public class DHAlgorithm
    {
        public static int GetSecretKey(int min, int max)
        {
            var random = new Random();
            return random.Next(min, max);
        }
        public static int FastExponent(int g, int a, int p)
        {
            //initial result = g ^ 1
            int result = g;

            var binary = Convert.ToString(a, 2);
            for (int i = 1; i < binary.Length; i++)
            {
                if (binary[i] == '1')
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
        public static void DHKeyExchange(int p, int g, int a, int b)
        {
            Console.WriteLine("\nDiffie Hellman Key Algorithm (p, g, a, b) : ({0},{1},{2},{3})", p, g, a, b);
            Console.WriteLine("\nPrivate Key of Alice : {0}", a);
            Console.WriteLine("Private Key of Bob : {0}", b);

            //Calcualte Public Key of Alice ( A = g^a mod p )
            int A = FastExponent(g, a, p);
            Console.WriteLine("\nPublic Key of Alice(A) : " + A);

            //Calcualte Public Key of Bob ( B = g^b mod p )
            int B = FastExponent(g, b, p);
            Console.WriteLine("Public Key of Bob(B) : " + B);

            //Exchange Key between Alice and Bob

            //Calculate Shared Secret Key at Alice Side ( Kab = B^a mod p )
            int Kab = FastExponent(B, a, p);
            Console.WriteLine("\nShared Secret Key at Alice Side : " + Kab);

            //Calculate Shared Secret Key at Bob Side ( Kba = A^b mod p )
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

            for (int i = 0; i < p - 1; i++)
            {
                int number = set[i];
                var orderSet = new List<int>();

                for (int j = 1; j < p; j++)
                    orderSet.Add(FastExponent(number, j, p));
                orderSet.Sort();
                var same = true;
                for (int j = 0; j < p - 1; j++)
                {
                    if (set[j] != orderSet[j])
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
    }
}
