using System;

namespace DateAndTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2000, 4, 18);
            Console.WriteLine(dateTime.ToLongDateString());
            Console.WriteLine(dateTime.ToLongTimeString());
            Console.WriteLine(dateTime.ToShortDateString());
            Console.WriteLine(dateTime.ToShortTimeString());
            var now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine("Current Year : " + now.Year);
            Console.WriteLine("Current Month : " + now.Month);
            Console.WriteLine("Current Day : " + now.Day);
            Console.WriteLine("Current Date : " + now.Date);
            Console.WriteLine("Current Hour : " + now.Hour);
            Console.WriteLine("Current Minute : " + now.Minute);
            Console.WriteLine("Current Second : " + now.Second);
            Console.WriteLine();
            Console.WriteLine("Time : " + now);
            Console.WriteLine();
            var yesterday = now.AddDays(-1);
            Console.WriteLine("Yesterday : " + yesterday);
            var tomorrow = now.AddDays(1);
            Console.WriteLine("Tomorrow : " + tomorrow);

            Console.WriteLine();
            Console.WriteLine("LongDate : " + now.ToLongDateString());
            Console.WriteLine("ShortDate : " + now.ToShortDateString());
            Console.WriteLine("LongTime : " + now.ToLongTimeString());
            Console.WriteLine("ShortTime : " + now.ToShortTimeString());
            Console.WriteLine("ShortTime : " + now.ToString());

            Console.WriteLine();
            Console.WriteLine("Formated : " + now.ToString("dddd d MMMM, yyyy hh:mm:ss tt"));
            Console.WriteLine();
            Console.WriteLine();

            var timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine(timeSpan);
            var timeHour = TimeSpan.FromSeconds(56);
            Console.WriteLine(timeHour);
            var timeMinute = TimeSpan.FromMinutes(40);
            Console.WriteLine(timeMinute);

            Console.WriteLine();
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(50);
            var diff = end - start;
            Console.WriteLine("Total Difference Time : " + diff);
            Console.WriteLine();
            Console.WriteLine("Current Time : " + timeSpan);
            Console.WriteLine("Minutes : " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes : " + timeSpan.TotalMinutes);
            Console.WriteLine("Seconds : " + timeSpan.Seconds);
            Console.WriteLine("Total Seconds : " + timeSpan.TotalSeconds);
            Console.ReadKey();
        }
    }
}
