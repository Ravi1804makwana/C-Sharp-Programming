using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnectionn
{
    public interface DbConnection
    {
        void Open();
        void Operations();
        void Close();
    }
    public class SqlConnection : DbConnection
    {
        public void Close()
        {
            Console.WriteLine("Close Sql Connection");
        }

        public void Open()
        {
            Console.WriteLine("Open Sql Connection");
        }

        public void Operations()
        {
            Console.WriteLine("Operation on Sql Database");
        }
    }

    public class Oracle : DbConnection
    {
        public void Close()
        {
            Console.WriteLine("Close Oracle Connection");
        }

        public void Open()
        {
            Console.WriteLine("Open Oracle Connection");
        }

        public void Operations()
        {
            Console.WriteLine("Operations on Oracle Database");
        }
    }
    public class DatabaseOperation
    {
        private readonly DbConnection dbConnection;

        public DatabaseOperation(DbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }
        public void PerformOperations()
        {
            dbConnection.Open();
            dbConnection.Operations();
            dbConnection.Close();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseOperation databaseOperation1 = new DatabaseOperation(new SqlConnection());
            databaseOperation1.PerformOperations();
            Console.WriteLine();
            DatabaseOperation databaseOperation2 = new DatabaseOperation(new Oracle());
            databaseOperation2.PerformOperations();
            Console.ReadKey();
        }
    }
}
