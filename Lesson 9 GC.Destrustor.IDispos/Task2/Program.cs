using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryController test = new MemoryController(100);
            test.ShowStatus();

            Array array = new int[1000];
            test.ShowStatus();

            Array array2 = new int[10000];
            test.ShowStatus();

            Console.ReadKey();


        }
    }
}
