using System;
using System.IO;

namespace DecisionTreeClassification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the file name : ");
            string line = Console.ReadLine();
            StreamReader reader = new StreamReader(line);
            reader.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Decision Tree Classification: -\n");
            Console.WriteLine("{0,-10}{1,-25}{2,-10}{3,-5}","Name","Rank","Years","Tenured");
            while ((line=reader.ReadLine())!=null)
            {
                var parts = line.Split(',');
                string rank = parts[1];
                int years = int.Parse(parts[2]);
                if (rank == "Professor" || years > 6)
                    Console.WriteLine("{0,-10}{1,-25}{2,-10}{3,-5}",parts[0],parts[1],parts[2],"Yes");
                else
                    Console.WriteLine("{0,-10}{1,-25}{2,-10}{3,-5}", parts[0], parts[1], parts[2],"No");
            }
            Console.ReadKey();
        }
    }
}
