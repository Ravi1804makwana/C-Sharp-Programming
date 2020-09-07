using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface Interface
    {
        void CallMe();
    }
    public class ClassA : Interface
    {
        public void CallMe()
        {
            Console.WriteLine("Class A");
        }
    }
    public class ClassB : Interface
    {
        public void CallMe()
        {
            Console.WriteLine("Class B");
        }
    }
    public class ClassC : Interface
    {
        public void CallMe()
        {
            Console.WriteLine("Class C");
        }
    }
    public class MainLogic
    {
        private readonly Interface demo;

        public MainLogic(Interface demo)
        {
            this.demo = demo;
        }
        public void Call()
        {
            demo.CallMe();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MainLogic mainLogic1 = new MainLogic(new ClassA());
            mainLogic1.Call();
            MainLogic mainLogic2 = new MainLogic(new ClassB());
            mainLogic2.Call();
            MainLogic mainLogic3 = new MainLogic(new ClassC());
            mainLogic3.Call();
            Console.ReadKey();
        }
    }
}
