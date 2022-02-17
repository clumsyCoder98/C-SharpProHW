using System;
using System.Threading;

namespace Additional_Task
{
    class Program
    {
        static object block = new object();
        static int counter;
        static void Method1()
        {
            for (int i = 0; i < 10; i++)
            {
                lock (block)
                {
                    counter++;
                    Console.WriteLine($"Counter: {counter}, threadID: {Thread.CurrentThread.ManagedThreadId}");
                }
            }
        }
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[3];
            ThreadStart start = new ThreadStart(Method1);
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(start);
                threads[i].Start();
                //Thread.Sleep(100);
            }

            Console.ReadKey();
        }
    }
}
