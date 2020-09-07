using System;

namespace InheritanceDemo
{
    abstract public class Person
    {
        public String name;
        public int age;
        public String jobProfile;
        public Person(String name, int age,String jobProfile)
        {
            this.name = name;
            this.age = age;
            this.jobProfile = jobProfile;
        }
        public abstract void Show();
    }
}
