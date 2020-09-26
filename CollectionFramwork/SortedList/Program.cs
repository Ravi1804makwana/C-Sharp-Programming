using System;
using System.Collections;
using System.Collections.Generic;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(5, "E");
            sortedList.Add(1,"A");
            sortedList.Add(3,"C");
            sortedList.Add(4,"D");
            sortedList.Add(2,"B");
            foreach(KeyValuePair<int,string> item in sortedList)
                Console.WriteLine(item.Key+" : "+item.Value);
            Console.ReadKey();
        }
    }
}
