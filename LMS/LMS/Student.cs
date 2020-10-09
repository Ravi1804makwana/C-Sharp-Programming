namespace Model
{
    public class Student:User
    {
        public int Semester, BookBalance;
        public string Branch;
        public static string HeaderLine;
        public Student(string name, int age, int userId, int semester, int bookBalance, string branch)
        :base(name,age,userId)
            {
            Semester = semester;
            BookBalance = bookBalance;
            Branch = branch;
        }
    }
}
