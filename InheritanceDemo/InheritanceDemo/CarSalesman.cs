using System;

namespace InheritanceDemo
{
    public class CarSalesman : Saleman
    {
        public CarSalesman(String name,int age,String jobProfile)
        : base(name, age, jobProfile) { }

        public void SalesCar()
        {
            Console.WriteLine("Sales Cars");
        }
    }
}
