using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInheritance
{
    public interface P
    {
        void ShowP();
    }
    public interface P1:P
    {
        void ShowP1();
    }
    public interface P2 : P
    {
        void ShowP2();
    }
    public interface P12 : P1,P2
    {
        void ShowP12();
    }
    public class Q : P12
    {
        public void ShowP()
        {
            Console.WriteLine("Show P");
        }

        public void ShowP1()
        {
            Console.WriteLine("Show P1");
        }

        public void ShowP12()
        {
            Console.WriteLine("Show P12");
        }

        public void ShowP2()
        {
            Console.WriteLine("Show P2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var q = new Q();
            q.ShowP();
            q.ShowP1();
            q.ShowP2();
            q.ShowP12();
            Console.ReadKey();
        }
    }
}
