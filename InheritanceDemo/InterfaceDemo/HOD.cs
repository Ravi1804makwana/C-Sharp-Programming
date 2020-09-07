using System;
namespace InterfaceDemo
{
    public class HOD : IPerson
    {
        public String name, jobProfile;
        public HOD(String name, String jobProfile)
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
