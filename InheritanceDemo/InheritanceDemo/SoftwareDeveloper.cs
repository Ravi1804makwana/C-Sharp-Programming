using System;

namespace InheritanceDemo
{
    public class SoftwareDeveloper : Developer, iDevelop
    {
        public SoftwareDeveloper(String name, int age, String jobProfile)
        : base(name, age, jobProfile) { }

        public void DevelopeSoftware()
        {
            Console.WriteLine("Development of Software");
        }
        public void SelfDevelop()
        {
            Console.WriteLine("Self Developmenr of Software Developer");
        }
    }
}
