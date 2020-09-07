using System;

namespace InheritanceDemo
{
    public class Saleman : Person
    {
        public Saleman(String name,int age,String jobProfile)
            : base(name, age, jobProfile){}
        public override void Show()
        {
            Console.WriteLine("Name        : "+name);
            Console.WriteLine("Age         : "+age);
            Console.WriteLine("Job Profile : "+jobProfile);
        }
    }
}
