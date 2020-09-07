using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    public class Stack
    {
        int i = -1;
        int []Data = new int[5];
        public void Push(int n)
        {
            if (i == 4)
                throw new InvalidOperationException("Stack is Overflow !");
            else
                Data[++i] = n;
        }
        public int Pop()
        {
            if (i == -1)
                throw new InvalidOperationException("Stack is Underflow !");
            else
                return Data[i--];
        }
        public void Clear()
        {
            i = 0;
        }
        public void Display()
        {
            Console.WriteLine();
            Console.Write("Stack Contains : ");
            for(int j=i;j>=0;j--)
                Console.Write(Data[j]+" ");
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            try
            {
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                stack.Push(4);
                stack.Push(5);
                stack.Push(6);
                stack.Display();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                stack.Display();
            }

            try
            {
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                stack.Display();
            }
            Console.ReadKey();

        }
    }
}
