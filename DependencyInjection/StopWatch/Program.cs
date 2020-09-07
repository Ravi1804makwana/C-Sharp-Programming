using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime StartTime;
        private DateTime EndTime;
        private bool running = false;
        public void Start(DateTime dateTime)
        {
            if (!running)
            {
                StartTime = dateTime;
            }
            else
                throw new InvalidOperationException("Activity is already Running");
        }
        public void Stop(DateTime dateTime)
        {
            if(running)
            {
                EndTime = dateTime;
                running = false;
            }
        }
        public int GetInterval()
        {
            var duration = EndTime.Second - StartTime.Second;
            return duration;
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch stopWatch = new StopWatch();
            var startTime = DateTime.Now;
            Console.WriteLine("Start Time : "+startTime);
            stopWatch.Start(startTime);
            
            Thread.Sleep(1000 * 4);
            
            var endTime = DateTime.Now;
            Console.WriteLine("End Time : " + endTime);
            stopWatch.Stop(endTime);
            
            Console.WriteLine("Interval : "+stopWatch.GetInterval().ToString());
            Console.ReadKey();
        }
    }
}
