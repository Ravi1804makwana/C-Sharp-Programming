using System;

namespace StructureDemo
{
    struct Student
    {
        public String firstName;
        public String lastName;
        public int age;

        public Student(String firstName, String lastName,int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public void Show()
        {
            Console.WriteLine("Fullname : {0} {1}",firstName, lastName);
            Console.WriteLine("Age : {0}",age);
        }
    }
}
