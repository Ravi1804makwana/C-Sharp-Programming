using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionFramwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayList Examples: ");
            ArrayList arrayList = new ArrayList();
            ArrayList newArrayList = new ArrayList() { "AAA", "BBB", "CCC" };
            arrayList.Add(1);
            arrayList.Add("A");
            arrayList.Add(2);
            arrayList.Add("B");
            arrayList.Add(3);
            arrayList.Add("C");
            arrayList.Add(4);
            arrayList.Add("D");
            arrayList.Add(5);
            arrayList.Add("E");
            ArrayList newArrayList1 = newArrayList;
            arrayList.AddRange(newArrayList);
            arrayList.Insert(3, "B TO BBBB");
            Console.WriteLine(String.Join(", ", arrayList.ToArray()));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("List Examples: ");
            List<int> list = new List<int>();
            List<int> newList = new List<int>() {11,22,33,44,55};
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.AddRange(newList);
            Console.WriteLine(String.Join(", ", list));
            Console.ReadKey();
        }
    }
}
