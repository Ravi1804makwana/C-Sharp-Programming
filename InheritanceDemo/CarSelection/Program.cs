using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSelection
{
    public interface ICar
    {
        void Start();
        void Stop();
        void Open();
        void Close();
    }
    public class Bronz : ICar
    {
        public void Close()
        {
            Console.WriteLine("Close method of Bronz");
        }

        public void Open()
        {
            Console.WriteLine("Open method of Bronz");
        }

        public void Start()
        {
            Console.WriteLine("Start method of Bronz");
        }

        public void Stop()
        {
            Console.WriteLine("Stop method of Bronz");
        }
    }
    public interface ISliverGold:ICar
    {
        void Automatic();
    }
    class Sliver : ISliverGold
    {
        public void Automatic()
        {
            Console.WriteLine("Automatic method of Sliver");
        }

        public void Close()
        {
            Console.WriteLine("Close method of Sliver");
        }

        public void Open()
        {
            Console.WriteLine("Open method of Sliver");
        }

        public void Start()
        {
            Console.WriteLine("Start method of Sliver");
        }

        public void Stop()
        {
            Console.WriteLine("Stop method of Sliver");
        }
    }
    public interface ICustimize:ISliverGold
    {
        void AirController();
    }
    public class Gold : ICustimize
    {
        public void AirController()
        {
            Console.WriteLine("AirController method of Gold");
        }

        public void Automatic()
        {
            Console.WriteLine("Automatic method of Gold");
        }

        public void Close()
        {
            Console.WriteLine("Close method of Gold");
        }

        public void Open()
        {
            Console.WriteLine("Open method of Gold");
        }

        public void Start()
        {
            Console.WriteLine("Start method of Gold");
        }

        public void Stop()
        {
            Console.WriteLine("Stop method of Gold");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var bronz = new Bronz();
            bronz.Start();
            bronz.Stop();
            bronz.Open();
            bronz.Close();

            Console.WriteLine();
            
            var sliver = new Sliver();
            sliver.Open();
            sliver.Close();
            sliver.Stop();
            sliver.Start();
            sliver.Automatic();

            Console.WriteLine();
            
            var gold = new Gold();
            gold.Open();
            gold.Close();
            gold.Start();
            gold.Stop();
            gold.Automatic();
            gold.AirController();

            Console.ReadKey();
        }
    }
}
