using System;

namespace InheritanceDemo
{
    public class WebDeveloper : Developer
    {
        public WebDeveloper(String name, int age, String jobProfile)
        : base(name, age, jobProfile) { }

        public void DevelopeWebsite()
        {
            Console.WriteLine("Development of Website");
        }
    }
}
