using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Staff : User
    {
        public int Salary;
        public string Post;
        public static string HeaderLine;
        public Staff(string name, int age, int userId, int salary, string post)
        :base(name,age,userId)
        {
            Salary = salary;
            Post = post;
        }
    }
}
