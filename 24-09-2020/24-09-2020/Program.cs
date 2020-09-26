using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _24_09_2020
{
    class Student
    {
        private string[] Name=new string[10];
        public string this[int index]
        {
            get { return Name[index]; }
            set { Name[index]=value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //PropertyDemo propertyDemo = new PropertyDemo();
            //propertyDemo.ReadWrite = 10;
            //Console.WriteLine(propertyDemo.ReadWrite);
            var student = new Student();
            student[0] = "Ravi";
            Console.WriteLine(student[0]);
            Console.ReadKey();
        }
    }
}
