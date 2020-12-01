using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingInDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            string ename, job;
            DateTime hiredate;
            int empno, mgr, sal, comm, deptno;

            string conString = "Data Source=RAVIMAKWANA;Initial Catalog=Employee;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using(SqlConnection con=new SqlConnection(conString))
            {
                try
                {
                    Console.WriteLine("Please enter the following details of employee.");
                    
                    Console.Write("Please enter the empno : ");
                    empno = int.Parse(Console.ReadLine()) ;
                    Console.Write("Please enter the ename : ");
                    ename = Console.ReadLine();
                    Console.Write("Please enter the job : ");
                    job = Console.ReadLine();
                    Console.Write("Please enter the mgr : ");
                    mgr = int.Parse(Console.ReadLine());
                    Console.Write("Please enter the hiredate (for example:(dd/mm/yyyy)) : ");
                    hiredate = DateTime.Parse(Console.ReadLine());
                    Console.Write("Please enter th salary : ");
                    sal = int.Parse(Console.ReadLine());
                    Console.Write("Please enter the commission : ");
                    comm = int.Parse(Console.ReadLine());
                    Console.Write("Please enter the department no. : ");
                    deptno = int.Parse(Console.ReadLine());

                    con.Open();
                    string sql = "INSERT INTO emp (empno, ename, job, mgr, hiredate, sal, comm, deptno) VALUES (@empno, @ename, @job, @mgr, @hiredate, @sal, @comm, @deptno)";
                    SqlCommand cmd = new SqlCommand(sql, con);

                    cmd.CommandType = CommandType.Text;
                    
                    cmd.Parameters.Add(new SqlParameter("@empno",empno));
                    cmd.Parameters.Add(new SqlParameter("@ename",ename));
                    cmd.Parameters.Add(new SqlParameter("@job",job));
                    cmd.Parameters.Add(new SqlParameter("@mgr",mgr));
                    cmd.Parameters.Add(new SqlParameter("@hiredate",hiredate));
                    cmd.Parameters.Add(new SqlParameter("@sal",sal));
                    cmd.Parameters.Add(new SqlParameter("@comm",comm));
                    cmd.Parameters.Add(new SqlParameter("@deptno",deptno));

                    int count = cmd.ExecuteNonQuery();
                    
                    Console.WriteLine();
                    if(count!=0)
                        Console.WriteLine("Number of Affected rows : "+count);
                    else
                        Console.WriteLine("Data is not inserted Successfully.");
                }
                catch (SqlException sqlException)
                {
                    //String sqlExceptionMessage = null;

                    //sqlExceptionMessage = "Index : " + sqlException.ToString();
                    //sqlExceptionMessage += "Type : " + sqlException.GetType().FullName;
                    //sqlExceptionMessage += "Message : " + sqlException.Message;
                    //sqlExceptionMessage = "Source : " + sqlException.Source;
                    //sqlExceptionMessage = "Number : " + sqlException.Number.ToString();
                    //sqlExceptionMessage = "State : " + sqlException.State.ToString();
                    //sqlExceptionMessage = "Class : " + sqlException.Class.ToString();
                    //sqlExceptionMessage = "Server : " + sqlException.Server;
                    //sqlExceptionMessage = "Procedure : " + sqlException.Procedure;
                    //sqlExceptionMessage = "LineNumber : " + sqlException.LineNumber.ToString();

                    //Console.WriteLine("Sql Exception Occur.........");
                    //Console.WriteLine();
                    //Console.WriteLine(sqlExceptionMessage);
                    Console.WriteLine();
                    Console.WriteLine("SQLException Occures ......");
                    Console.WriteLine();
                    Console.WriteLine(sqlException.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine("Exception Message :" + ex.Message);
                    Console.WriteLine();
                }
                finally
                {
                    Console.WriteLine("Finally Block");
                }

                Console.ReadKey();
            }
        }
    }
}
