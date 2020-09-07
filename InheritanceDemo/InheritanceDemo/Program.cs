using System;
namespace InheritanceDemo
{
class Program
    {
        static void Main(string[] args)
        {
            var carSalesman=new CarSalesman("A",19,"CarSalesman");
            carSalesman.Show();
            carSalesman.SalesCar();
            
            Console.WriteLine();

            var retailSalesman = new RetailSalesman("B",12,"RetailSalesman");
            retailSalesman.Show();
            retailSalesman.SalesRetail();
            retailSalesman.SelfDevelop();
            
            Console.WriteLine();

            var webDeveloper = new WebDeveloper("Ravi",19,"Full Stack Web Developer");
            webDeveloper.Show();
            webDeveloper.DevelopeWebsite();

            Console.WriteLine();

            var softwareDeveloper = new SoftwareDeveloper("C",38,"Software Development");
            softwareDeveloper.Show();
            softwareDeveloper.DevelopeSoftware();
            softwareDeveloper.SelfDevelop();

            Console.ReadKey();
        }
    }
}
