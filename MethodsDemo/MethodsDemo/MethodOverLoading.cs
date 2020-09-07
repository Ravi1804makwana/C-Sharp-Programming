using System;
namespace MethodsDemo
{
    public class MethodOverLoading
    {
        public void add(int a,int b)
        {
            Console.WriteLine("a + b {0}",a + b) ;
        }
        public void add(int a,int b,int c)
        {
            Console.WriteLine("a + b + c {0}", a +b+c);
        }
        public void add(int a,int b,int c,int d)
        {
            Console.WriteLine("a + b + c + d {0}", a +b+c+d);
        }
        public void add(int a,int b,int c,int d,int e)
        {
            Console.WriteLine("a + b + c + d + e {0}", a +b+c+d+e);
        }
    }
}
