using System;

namespace OOPExamples
{
    public class InterMediateClass:BaseClass
    {
        public InterMediateClass()
        {
            Console.WriteLine("Intermediate Class");
        }
        public InterMediateClass(String myName):base(myName)
        {
            Console.WriteLine("Intermediate Class");
        }
    }
}
