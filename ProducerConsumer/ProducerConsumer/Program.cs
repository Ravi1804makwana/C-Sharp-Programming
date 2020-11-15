using System;
using System.Net.Http.Headers;
using System.Threading;

namespace ProducerConsumer
{
    public class Queue
    {
        int[] Trolley = new int[5];
        int ip = -1, ic = -1;

        public void Put(int number, string producerName)
        {
            lock(this)
            {
                if(ic==ip+1 || (ic==0 && ip==4))
                {
                    Monitor.Wait(this);
                }
                
                if (ip == -1)
                    ic = ip = 0;
                else
                    ip = (ip + 1) % 5;
                
                Trolley[ip] = number;
                Console.WriteLine(producerName+" :: "+number);
                Monitor.PulseAll(this);
            }
        }
        public int Get(string consumerName)
        {
            lock(this)
            {
                if (ic == -1)
                    Monitor.Wait(this);
                
                int value = Trolley[ic];
                
                Monitor.PulseAll(this);
                
                Console.WriteLine(consumerName+" :: "+value);

                if (ic == ip)
                    ic = ip = -1;
                else
                    ic = (ic + 1) % 5;
                return value;
            }
        }
    }
    public class Producer
    {
        private Queue MyQueue;
        private string Name;
        public Producer(Queue queue, string name)
        {
            this.MyQueue = queue;
            this.Name = name;
        }
        public void ProduceProducts()
        {
            int i = 0;
            while(true)
            {
                MyQueue.Put(i++, Name);
                Thread.Sleep(100);
            }
        }
    }
    public class Consumer
    {
        private Queue MyQueue;
        private string Name;
        public Consumer(Queue queue, string name)
        {
            this.MyQueue = queue;
            this.Name = name;
        }
        public void ConsumeProducts()
        {
            while(true)
            {
                MyQueue.Get(Name);
                Thread.Sleep(1500);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            Producer producer1 = new Producer(queue,"Producer 1");
            Thread thread1 = new Thread(producer1.ProduceProducts);
            thread1.Start();
            
            Consumer consumer1 = new Consumer(queue, "Consumer 1");
            Thread thread2 = new Thread(consumer1.ConsumeProducts);
            thread2.Start();

            //Producer producer2 = new Producer(queue, "Produce 2");
            //Thread thread3 = new Thread(producer2.ProduceProducts);
            //thread3.Start();

            //Consumer consumer2 = new Consumer(queue, "Consume 2");
            //Thread thread4 = new Thread(consumer2.ConsumeProducts);
            //thread4.Start();
        }
    }
}
