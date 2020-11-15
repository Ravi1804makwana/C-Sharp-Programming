using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

namespace MyFirstDatabaseApp
{
    public class Customer
    {
        public int Id;
        public string Name;

        public Customer() { }
        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void Show()
        {
            Console.WriteLine("Id : "+Id+" , Name : "+Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=G:\\C# Programming\\MyFirstDatabaseApp\\MyFirstDatabaseApp\\Employee.mdf;Integrated Security=True");
            string sql = "Update Customer set name = @name where id= @id";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add(new SqlParameter("@name","Gujart Technical University"));
            cmd.Parameters.Add(new SqlParameter("@id", 3));
            cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            Console.ReadKey();
        }
    }
}
