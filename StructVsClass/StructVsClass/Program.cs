using System;

namespace StructVsClass
{
    public struct ValuesOfObject
    {
        String val = new string[5];
        public String this[int index]
        {
            get { return this[index]; }
            set { this[index] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Books book1 = new Books("Life Motivation","Ravikumar Makwana","V.V.P. Engineering College",500.10);
            book1.Display();

            Console.WriteLine();
            Books book2;
            book2.Title = "Motivation@Ravikumar Makwana";
            book2.Author = "Ravikumar Makawna";
            book2.Publication = "V.V.P. Engineering College";
            book2.Price = 80.10;
            book2.Display();

            ValuesOfObject valuesOfObject;
            valuesOfObject[0] = "A";
            valuesOfObject[1] = "B";
            valuesOfObject[2] = "C";
            valuesOfObject[3] = "D";
            valuesOfObject[4] = "E";

            for(int i=0;i<5;i++)
                Console.Write(valuesOfObject[i]+"\n");

            Console.ReadKey();
        }
    }
}
