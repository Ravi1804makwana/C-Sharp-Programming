using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data<int> intData = new Data<int>(1);
            //Console.WriteLine("Initial Value : "+intData.MyProperty);
            //intData.MyProperty = 10;
            //Console.WriteLine("Updated Value : "+intData.MyProperty);
            //Console.WriteLine();

            //Data<string> stringData = new Data<string>("Ravi");
            //Console.WriteLine("Initial Value : "+stringData.MyProperty);
            //stringData.MyProperty = "Ravikumar";
            //Console.WriteLine("Updated Value : "+stringData.MyProperty);

            //KeyValuePairs<int, string> keyValuePairs = new KeyValuePairs<int, string>(1,"Secret Value");
            //Console.WriteLine(keyValuePairs.MyKey+" : "+keyValuePairs.MyValue);           

            NonGenericClass nonGenericClass = new NonGenericClass();
            nonGenericClass.Show<int>(1,2,3,4,5);
            nonGenericClass.Show<string>("A","B","C","D","E");
            nonGenericClass.Show<double>(1.1,1.2,1.3,1.4,1.5);
            Console.ReadKey();
        }
    }
}
