using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace HashTableVsDictionary
{
    public class Student
    {
        public string Name;
        public int Age;
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Show()
        {
            return "Name : " + this.Name + ", Age : " + Age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "Ravikumar Makwana");
            hashtable.Add(2, "Makwana Ravikumar");
            hashtable.Add("17CE014", "Ravi Makwana");

            ICollection keys = hashtable.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine(key + " : " + hashtable[key]);
            }
            Console.WriteLine();
            hashtable.Remove("17CE014");
            foreach (var key in keys)
            {
                Console.WriteLine(key + " : " + hashtable[key]);
            }
            //Dictionary<int, Student> studentInfo = new Dictionary<int, Student>();
            //Console.WriteLine("How manay students that you need to enter ?");
            //int c = int.Parse(Console.ReadLine());
            //for(int i=0;i<c;i++)
            //{
            //    Console.WriteLine("Student {0}",(i+1));
            //    Console.Write("Age : ");
            //    int age = int.Parse(Console.ReadLine());
            //    Console.Write("Name : ");
            //    string name = Console.ReadLine();
            //    studentInfo[i] = new Student(name,age);
            //}

            //Console.WriteLine("Display Student Details");
            //foreach (KeyValuePair<int,Student> item in studentInfo)
            //    Console.WriteLine(item.Key+" : "+item.Value.Name);
            Console.ReadKey();
        }
    }
}
