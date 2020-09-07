using System;

namespace OOPExamples
{
    public class B : A
    {
        int b;
        public B(int a,int b):base(a)
        {
            this.b = b;
        }
        public void ShowB()
        {
            Console.WriteLine("Child Class b :"+b);
        }
    } 
}
