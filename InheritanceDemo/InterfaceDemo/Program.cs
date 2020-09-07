using System;
namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Consloe Logger : ");
            //var dbMigrator = new DbMigrator(new ConsoleLogger());
            //dbMigrator.Migrator();

            //Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.WriteLine("File Logger : ");
            //var dbMigrator1 = new DbMigrator(new FileLogger());
            //dbMigrator1.Migrator();

            var member1 = new Members(new Student("Ravikumar Makwana", "Student"));
            var member2 = new Members(new Staff("Sagar Virani", "Faculty"));
            var member3 = new Members(new HOD("Tajes Patily","Head Of Computer Engineering Department"));
            member1.Show();
            Console.WriteLine();
            member2.Show();
            Console.WriteLine();
            member3.Show();

            Console.ReadKey();
        }
    }
}
