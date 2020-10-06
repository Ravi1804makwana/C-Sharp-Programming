#define PI
#define PI1
#undef P
using System;

namespace PreprocessorDirectives
{
    class Program
    {
        static void Main(string[] args)
        {
            #if (!PI)
                Console.WriteLine("PI is not Define");
            #elif (!PI1)
                Console.WriteLine("PI1 is not Define");
            #elif (PI && !PI1)
                Console.WriteLine("PI is Define, but PI1 is not Define");
            #elif (PI && !PI1)
                Console.WriteLine("PI1 is Define, but PI is not Define");
            #elif (PI && PI1)
                Console.WriteLine("PI and PI1 both are Define");
            #else
                Console.WriteLine("PI and PI1 Both are not Define");
            #endif
            
            Console.WriteLine("-----------------------------------");

            #if (P)
                Console.WriteLine("P is Define");
            #else
                Console.WriteLine("P is Not Define");
            #endif
                Console.WriteLine("-----------------------------------");
            #if P
            #error P is define
            #endif
            Console.ReadKey();
        }
    }
}
