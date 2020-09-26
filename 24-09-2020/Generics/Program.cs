using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //class DataStore<T>
    //{
    //    public T Data
    //    {
    //        set; get;
    //    }
    //}
    //class Customer
    //{
    //    private int CustomerId;
    //    public string CustomerName;
    //    public Customer(int customerId, string customerName)
    //    {
    //        this.CustomerId = customerId;
    //        this.CustomerName = customerName;
    //    }
    //    public int UpdateId
    //    {
    //        get { return CustomerId; }
    //        set { CustomerId = value; }
    //    }

    //    public override string ToString()
    //    {
    //        return "CustomerId : " + CustomerId + ", CustomerName : " + CustomerName;
    //    }
    //}
    //class KeyValuePair<TKey, TValue>
    //{
    //    public TKey Key
    //    {
    //        get;set;
    //    }
    //    public TValue Value
    //    {
    //        get; set;
    //    }
    //}
    //class Display
    //{
    //    /**
    //        Non-Generic class in generic methods
    //     */
    //    public void Show<T>(params T[] list)
    //    {
    //        int length = list.Length;
    //        foreach(var i in list)
    //        {
    //            Console.Write(i+"  ");
    //        }
    //        Console.WriteLine();
    //    }
    //}
    //class MyArray<T>
    //{
    //    private T[] array = new T[10];


    //    public T this[int index]
    //    {
    //        get{
    //            return array[index];
    //        }
    //        set{
    //            array[index]=value;
    //        }
    //    }
    //}


    class Employee<TId, TName>
    {
        private TId EmployeeId;
        private TName EmployeeName;
        public Employee(TId employeeId, TName employeeName)
        {
            this.EmployeeId = employeeId;
            this.EmployeeName = employeeName;
        }
        public void Show()
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine("Employee ID : "+EmployeeId);
            Console.WriteLine("Employee Name : "+EmployeeName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //DataStore<string> dataStore1 = new DataStore<string>();
            //dataStore1.Data = "Hello World";
            //Console.WriteLine(dataStore1.Data);

            //DataStore<int> dataStore2 = new DataStore<int>();
            //dataStore2.Data = 100;
            //Console.WriteLine(dataStore2.Data);

            //KeyValuePair<int, string> keyValuePair = new KeyValuePair<int, string>();
            //keyValuePair.Key = 1;
            //keyValuePair.Value = "Ravikumar Makwana";
            //Console.WriteLine("Key: {0} and Value : {1}", keyValuePair.Key, keyValuePair.Value);

            //KeyValuePair<int, Customer> ecommerce = new KeyValuePair<int, Customer>();
            //ecommerce.Key = 1;
            //ecommerce.Value = new Customer(1,"Ravi");

            //Console.WriteLine(ecommerce.Key +" : "+ ecommerce.Value.ToString());

            //Display display = new Display();
            //display.Show(1,2,3,4);
            //display.Show("A","B","C","D");
            //display.Show('a','b','c','d');
            //display.Show(1.1,1.2,1.3,1.4);

            //MyArray<int> myArray = new MyArray<int>();

            //myArray[0] = 1;
            //myArray[1] = 2;
            //myArray[2] = 3;
            //myArray[3] = 4;
            //myArray[4] = 5;
            //myArray[5] = 6;
            //myArray[6] = 7;
            //myArray[7] = 8;
            //myArray[8] = 9;
            //myArray[9] = 10;
            //for(var i=0;i<10;i++)
            //    Console.Write(myArray[i]+" ");
            //Console.WriteLine();

            //MyArray<string> myArray1 = new MyArray<string>();

            //myArray1[0] = "Aaa";
            //myArray1[1] = "Bbb";
            //myArray1[2] = "Ccc";
            //myArray1[3] = "Ddd";
            //myArray1[4] = "Eee";
            //myArray1[5] = "Fff";
            //myArray1[6] = "Ggg";
            //myArray1[7] = "Hhh";
            //myArray1[8] = "Iii";
            //myArray1[9] = "Jjj";
            //for (var i = 0; i < 10; i++)
            //    Console.Write(myArray1[i] + " ");
            //Console.WriteLine();

            Employee<long,string> employee1 = new Employee<long, string>(170470107030,"Ravikumar Makwana");
            Employee<string, string> employee2 = new Employee<string, string>("17CE014", "Ravikumar Makwana");
            employee1.Show();
            Console.WriteLine();
            employee2.Show();

            Console.ReadKey();
        }
    }
}
