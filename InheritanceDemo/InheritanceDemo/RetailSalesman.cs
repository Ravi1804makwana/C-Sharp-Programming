using System;

namespace InheritanceDemo
{
    public class RetailSalesman : Saleman, iDevelop
    {
        public RetailSalesman(String name, int age, String jobProfile)
        : base(name, age, jobProfile) { }

        public void SalesRetail()
        {
            Console.WriteLine("Retail Salesman");
        }
        public void SelfDevelop()
        {
            Console.WriteLine("Self Development of Retail Salesman");
        }
    }
}
