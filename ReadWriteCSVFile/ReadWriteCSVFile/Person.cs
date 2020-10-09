using System.Collections.Generic;
using System.IO;

namespace ReadWriteCSVFile
{
    class Person
    {
        public string Name;
        public int Age;
        public string HeaderLine;
        public List<Person> students = new List<Person>();
        public Person()
        {
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void GetData()
        {
            StreamReader reader = new StreamReader("Student.csv");
            HeaderLine = reader.ReadLine();
            string line = "";
            while ((line = reader.ReadLine()) != null)
            {
                var part = line.Split(',');
                students.Add(new Person(part[0], int.Parse(part[1])));
            }
            reader.Close();
        }
        public void PutData()
        {
            StreamWriter writer = new StreamWriter("Student.csv");
            writer.WriteLine(HeaderLine);
            foreach (var student in students)
            {
                var person = student;
                writer.WriteLine(person.Name + "," + person.Age);
            }
            writer.Close();
        }
    }
}
