using System;
using System.Threading;

namespace Task3
{
    class Program
    {
        static Mutex mutex = new Mutex(true, "L12T3"); // походу если true то второй екземпляр приложения не
        //будет работать, тк после завершения 1 во 2 вылетает ошибка (running stop due to abadoned mutex)
        //(если false - отрабатывает второе)
        static void Main(string[] args)
        {
            mutex.WaitOne();

            Console.WriteLine("App is running!");
            Console.WriteLine("Press any key to stop:");
            Console.ReadKey();

            mutex.ReleaseMutex();
        }
    }
}
