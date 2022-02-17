using System;
using System.Threading;
using System.IO;

namespace AdditionalTask
{
    class Program
    {
        static Semaphore semaphore;
        static void Logger()
        {
            semaphore.WaitOne();
            string info = $"Thread {Thread.CurrentThread.ManagedThreadId}, logged to file at: {DateTime.Now}\n";
            File.AppendAllText("Logger.log", info);
            semaphore.Release();
        }
        static void Main(string[] args)
        {
            semaphore = new Semaphore(2, 4, "L12Logger");
            for (int i = 0; i <10; i++)
            {
                new Thread(Logger).Start();
                Thread.Sleep(300);
            }
            Console.WriteLine("Program is over!");
            Console.ReadKey();
        }
    }
}
