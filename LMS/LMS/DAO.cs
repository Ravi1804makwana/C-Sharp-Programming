using System.Collections.Generic;
using System.IO;

namespace Model
{
    public class DAO
    {
        /**
        *   
        *   Author : Ravikumar Makwana
        *   Aim : Data Access Object
        *
        */
        public static List<Student> student = new List<Student>();
        public static List<Staff> staff = new List<Staff>();
        public static List<HardMedia> hardMedia = new List<HardMedia>();
        public static List<SoftMedia> softMedia = new List<SoftMedia>();
        public void GetData()
        {
            StreamReader readerStudent = new StreamReader("Student.csv");
            Student.HeaderLine = readerStudent.ReadLine();

            string line = "";
            while((line=readerStudent.ReadLine())!=null)
            {
                var parts = line.Split(',');
                student.Add(new Student(parts[0],int.Parse(parts[1]), int.Parse(parts[2]),int.Parse(parts[3]), int.Parse(parts[4]), parts[5]));
            }
            readerStudent.Close();

            StreamReader readerStaff = new StreamReader("Staff.csv");
            Staff.HeaderLine = readerStaff.ReadLine();

            line = "";
            while ((line = readerStaff.ReadLine()) != null)
            {
                var parts = line.Split(',');
                staff.Add(new Staff(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]),parts[4]));
            }
            readerStaff.Close();

            StreamReader readerSoftMedia = new StreamReader("SoftMedia.csv");
            SoftMedia.HeaderLine = readerSoftMedia.ReadLine();

            line = "";
            while ((line = readerSoftMedia.ReadLine()) != null)
            {
                var parts = line.Split(',');
                softMedia.Add(new SoftMedia(parts[0],parts[1],int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4])));
            }
            readerSoftMedia.Close();

            StreamReader readerHardMedia = new StreamReader("HardMedia.csv");
            HardMedia.HeaderLine = readerHardMedia.ReadLine();

            line = "";
            while((line=readerHardMedia.ReadLine())!=null)
            {
                var parts = line.Split(',');
                hardMedia.Add(new HardMedia(parts[0],parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4])));
            }
            readerHardMedia.Close();
        }
        public void PutData()
        {
            StreamWriter writerStudent = new StreamWriter("Student.csv");
            writerStudent.WriteLine(Student.HeaderLine);

            foreach (var item in student)
            {
                var tempStudent = item;
                writerStudent.WriteLine(tempStudent.Name+","+tempStudent.Age + "," + tempStudent.UserId + "," + tempStudent.Semester + "," + tempStudent.BookBalance + "," + tempStudent.Branch);
            }
            writerStudent.Close();

            StreamWriter writerStaff = new StreamWriter("Staff.csv");
            writerStaff.WriteLine(Staff.HeaderLine);

            foreach (var item in staff)
            {
                var tempStaff = item;
                writerStaff.WriteLine(tempStaff.Name + "," + tempStaff.Age + "," + tempStaff.UserId + "," + tempStaff.Salary+","+tempStaff.Post);
            }
            writerStaff.Close();
            
            StreamWriter writerHardMedia = new StreamWriter("HardMedia.csv");
            writerHardMedia.WriteLine(HardMedia.HeaderLine);

            foreach (var item in hardMedia)
            {
                var tempHardMedia = item;
                writerHardMedia.WriteLine(tempHardMedia.Title+","+tempHardMedia.Author + "," + tempHardMedia.Stock + "," + tempHardMedia.IsbnNo+","+tempHardMedia.PageNo);
            }
            writerHardMedia.Close();
            
            StreamWriter writerSoftMedia = new StreamWriter("SoftMedia.csv");
            writerSoftMedia.WriteLine(SoftMedia.HeaderLine);

            foreach (var item in softMedia)
            {
                var tempSoftMedia = item;
                writerSoftMedia.WriteLine(tempSoftMedia.Title + "," + tempSoftMedia.Author + "," + tempSoftMedia.Stock + "," + tempSoftMedia.IsbnNo+","+tempSoftMedia.Time);
            }
            writerSoftMedia.Close();
        }
    }


}
