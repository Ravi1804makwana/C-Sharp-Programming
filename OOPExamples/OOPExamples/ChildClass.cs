using System;

namespace OOPExamples
{
    public class ChildClass:InterMediateClass
    {
        public ChildClass()
        {
            Console.WriteLine("Child Class");
        }
        public ChildClass(String myName) : base(myName)
        {
            Console.WriteLine("Child Class");
        }
    }
}
