using System;
namespace InterfaceDemo
{
    public class Staff : IPerson
    {
        public String name, jobProfile;
        public Staff(String name, String jobProfile)
        {
            this.name = name;
            this.jobProfile = jobProfile;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Job Profile : " + jobProfile);
        }
    }
}
