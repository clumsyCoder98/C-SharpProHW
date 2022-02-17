using System;
using System.Threading;

namespace Task2
{
    class Program
    {
        static ManualResetEvent blocker;
        static void Method1()
        {
            Console.WriteLine("Thread 1 is running and wait for signal");
            blocker.WaitOne();
            Console.WriteLine("Thread 1 is over after receiving a signal");
        }

        static void Method2()
        {
            Console.WriteLine("Thread 2 is running and wait for signal");
            blocker.WaitOne();
            Console.WriteLine("Thread 2 is over after receiving a signal");
        }

        static void Main(string[] args)
        {
            blocker = new ManualResetEvent(false); // при ManualResetEvent Set общий для всех команд WaitOne;
            new Thread(Method1).Start();
            new Thread(Method2).Start();
            blocker.Set();
            //blocker.Set(); // При AutoResetEvent Set нужен для каждого WaitOne; 
            Console.ReadKey();
        }
    }
}
