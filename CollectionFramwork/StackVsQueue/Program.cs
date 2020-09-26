using System;
using System.Collections;
using System.Collections.Generic;

namespace StackVsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //stack.Push(6);
            //stack.Push(7);
            //stack.Push(8);
            //stack.Push(9);
            //stack.Push(10);
            //Console.Write("Display Stack : ");
            //foreach (var item in stack)
            //    Console.Write(item+" ");
            //Console.WriteLine();
            //Console.WriteLine("stack.Peek() : " + stack.Peek());
            //Console.WriteLine("stack.Pop()  : " + stack.Pop());
            //Console.WriteLine("stack.Peek() : " + stack.Peek());
            //Console.WriteLine("stack.Pop()  : " + stack.Pop());
            //Console.WriteLine("stack.Peek() : " + stack.Peek());
            //Console.WriteLine("stack.Pop()  : " + stack.Pop());
            //Console.WriteLine("stack.Peek() : " + stack.Peek());
            //Console.WriteLine("stack.Pop()  : " + stack.Pop());
            //stack.Push(100);
            //Console.WriteLine("stack.Push(100)");
            //Console.Write("Display Stack : ");
            //foreach (var item in stack)
            //    Console.Write(item + " ");
            //Console.WriteLine();
            //Console.WriteLine("stack.Contains(4) : "+stack.Contains(4));
            //Console.WriteLine("stack.Contains(40) : " + stack.Contains(40));

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);
            Console.Write("Display Queue : ");
            foreach (var item in queue)
                Console.Write(item+" ");
            Console.WriteLine();
            Console.WriteLine("queue.Dequeue() : " + queue.Dequeue());
            Console.WriteLine("queue.Dequeue() : " + queue.Dequeue());
            Console.WriteLine("queue.Enqueue(100)");
            queue.Enqueue(100);
            Console.Write("Display Queue : ");
            foreach (var item in queue)
                Console.Write(item + " ");
            Console.ReadKey();
        }
    }
}
