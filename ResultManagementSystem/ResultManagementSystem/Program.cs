using System;
using System.Collections.Generic;
using System.IO;

namespace ResultManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Result> results = new List<Result>();

            StreamReader reader = new StreamReader("Database.csv");
            string headerLine = reader.ReadLine();
            string line = null;

            while((line=reader.ReadLine())!=null)
            {
                var parts = line.Split(',');
                results.Add(new Result(int.Parse(parts[0]), parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]), int.Parse(parts[8]), int.Parse(parts[9]), int.Parse(parts[10]), int.Parse(parts[11])));
            }
            for(int i=0;i<results.Count;i++)
            {
                results[i].ExamMarksEntry();
                results[i].SportMarksEntry();
                results[i].TechnicalMarksEntry();
                results[i].NonTechnicalMarksEntry();
                results[i].AptitudeMarksEntry();
                results[i].ComputeFinalResult();
            }
            Console.WriteLine("*** Final Result ***");
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(String.Format("| {0, 10} | {1, -20} | {2, -20} | {3, 20} | {4, 20}  | {5, 20} |", "Roll No.","Name","Department", "Total Marks", "Result", "Comment"));
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            
            for (int i = 0; i<results.Count; i++)
                results[i].ShowResult();
            
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");

            Console.ReadKey();
        }
    }
}
