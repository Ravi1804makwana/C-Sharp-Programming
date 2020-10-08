using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace PropertiesExamples
{
    class Person
    {
        private string _name;
        private readonly int _age;
        private long _phoneNo;

        public string AutomaticProperty { get; set; }
        public Person(string name,int age, long phoneNo)
        {
            this._name = name;
            this._age = age;
            this._phoneNo = phoneNo;
        }
        public Person()
        {
            //default Constructor
        }

        //Read-Write Property
        public string Name
        { 
            get
            {
                return _name;
            }
            set {
                _name = value;
            }
        }

        //Read only Properties
        public int Age
        {
            get
            {
                return _age;
            }
        }

        //Write only Properties
        public long PhoneNo
        {
            set
            {
                _phoneNo = value;
            }
        }
        public void ShowInformation()
        {
            Console.WriteLine("Person Information");
            Console.WriteLine("Name : " + _name);
            Console.WriteLine("Age : " + _age);
            Console.WriteLine("Phone No : " + _phoneNo);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Ravi",20,123456);
            
            p.Name = "Ravikumar Makwana";
            Console.WriteLine("get Property of Name : "+p.Name);

            p.PhoneNo = 6354508988;
            // Write only property
            //Console.WriteLine(p.PhoneNo);

            //Read only Properties
            //p.Age = 18;

            p.ShowInformation();

            Console.WriteLine();
            Console.WriteLine("Automatic Property");
            p.AutomaticProperty = "Hello World";
            Console.WriteLine(p.AutomaticProperty);
            Console.ReadKey();
        }
    }
}
