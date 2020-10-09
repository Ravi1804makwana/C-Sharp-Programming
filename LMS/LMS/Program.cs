using System;
using Controller;
using Model;
namespace View
{
    public class Program
    {
        /**
        *
        *   Author : Ravikumar Makwana
        *   Aim : User Interface
        *
        */
        public static void Main(string []args)
        {
            Console.WriteLine("... Welcome to Library Management System ...");
            Console.WriteLine();
            DAO dAO = new DAO();
            Transactions transactions = new Transactions();
            dAO.GetData();
            int userId, isbnNo,time,stock,pageNo, age,semester,salary;
            string title, author,name,branch,post;
            string mediaType;

            while (true)
            {
                try
                {
                    Console.WriteLine("1. Issue Book");
                    Console.WriteLine("2. Return Book");
                    Console.WriteLine("3. Check Balance");
                    Console.WriteLine("4. Search Materials");
                    Console.WriteLine("5. Add new Soft Materials");
                    Console.WriteLine("6. Add new Hard Materials");
                    Console.WriteLine("7. Add new Students");
                    Console.WriteLine("8. Add new Staffs");
                    Console.WriteLine("9. Exit");
                    Console.Write("Please enter the your choice : ");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.WriteLine("** Issue Book **");
                            Console.Write("Please enter the your userId : ");
                            userId = int.Parse(Console.ReadLine());
                            Console.Write("Please enter the your media type : ");
                            mediaType = Console.ReadLine();
                            Console.Write("Please enter the your Isbn No : ");
                            isbnNo = int.Parse(Console.ReadLine());
                            
                            Console.WriteLine(transactions.IssueBook(userId,isbnNo, mediaType));
                            break;

                        case 2:
                            Console.WriteLine();
                            Console.WriteLine("** Return Book **");
                            Console.Write("Please enter the your userId : ");
                            userId = int.Parse(Console.ReadLine());
                            Console.Write("Please enter the your media type : ");
                            mediaType = Console.ReadLine();
                            Console.Write("Please enter the your Isbn No : ");
                            isbnNo = int.Parse(Console.ReadLine());

                            Console.WriteLine(transactions.ReturnBook(userId, isbnNo, mediaType));
                            break;

                        case 3:
                            Console.WriteLine();
                            Console.WriteLine("** Check Book Balance **");
                            Console.Write("Please enter the userId : ");
                            userId = int.Parse(Console.ReadLine());

                            Console.WriteLine(transactions.CheckBalance(userId));
                            break;

                        case 4:
                            Console.WriteLine();
                            Console.WriteLine("** Search Materials **");
                            Console.Write("Please enter the search keywords: ");
                            string material = Console.ReadLine();
                            
                            Console.WriteLine(transactions.SearchMaterial(material));
                            break;

                        case 5:
                            Console.WriteLine();
                            Console.WriteLine("** Add new Soft Materials **");
                            
                            Console.WriteLine();
                            
                            Console.WriteLine("Please enter the following details");
                            
                            Console.Write("Isbn Number : ");
                            isbnNo = int.Parse(Console.ReadLine());
                            Console.Write("Title : ");
                            title = Console.ReadLine();
                            Console.Write("Author : ");
                            author = Console.ReadLine();
                            Console.Write("Stock : ");
                            stock = int.Parse(Console.ReadLine());
                            Console.Write("Duration (Number of Hours) : ");
                            time = int.Parse(Console.ReadLine());

                            DAO.softMedia.Add(new SoftMedia(title,author,stock,isbnNo,time));

                            Console.WriteLine("Successful : New Softmedia Added Successfully");
                            break;

                        case 6:
                            Console.WriteLine();
                            Console.WriteLine("** Add new Hard Materials **");

                            Console.WriteLine();

                            Console.WriteLine("Please enter the following details");

                            Console.Write("Isbn Number : ");
                            isbnNo = int.Parse(Console.ReadLine());
                            Console.Write("Title : ");
                            title = Console.ReadLine();
                            Console.Write("Author : ");
                            author = Console.ReadLine();
                            Console.Write("Stock : ");
                            stock = int.Parse(Console.ReadLine());
                            Console.Write("Page Numbers : ");
                            pageNo = int.Parse(Console.ReadLine());

                            DAO.hardMedia.Add(new HardMedia(title, author, stock, isbnNo, pageNo));

                            Console.WriteLine("Successful : New Hardmedia Added Successfully");
                            break;

                        case 7:
                            Console.WriteLine();
                            Console.WriteLine("** Add New Students **");
                            
                            Console.WriteLine();
                            Console.WriteLine("Please enter the following Details");
                            Console.Write("User Id : ");
                            userId = int.Parse(Console.ReadLine());
                            Console.Write("Name : ");
                            name = Console.ReadLine();
                            Console.Write("Age : ");
                            age = int.Parse(Console.ReadLine());
                            Console.Write("Semester : ");
                            semester = int.Parse(Console.ReadLine());
                            Console.Write("Branch : ");
                            branch = Console.ReadLine();

                            DAO.student.Add(new Student(name,age,userId,semester,4,branch));
                            Console.WriteLine("Successful :  New Student added Successfully.");
                            break;

                        case 8:
                            Console.WriteLine();
                            Console.WriteLine("** Add New Staff **");
                            Console.WriteLine();

                            Console.WriteLine("Please enter the following details : ");
                            Console.Write("Name : ");
                            name = Console.ReadLine();
                            Console.Write("Age : ");
                            age = int.Parse(Console.ReadLine());
                            Console.Write("User Id : ");
                            userId = int.Parse(Console.ReadLine());
                            Console.Write("Salary : ");
                            salary = int.Parse(Console.ReadLine());
                            Console.Write("Post : ");
                            post = Console.ReadLine();

                            DAO.staff.Add(new Staff(name,age,userId,salary,post));

                            Console.WriteLine("Successful : New Staff added Successfully");
                            break;

                        case 9:
                            dAO.PutData();
                            Console.WriteLine("Thanking for Use of Online Library ...");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Please select right choice.");
                            break;
                    }
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
