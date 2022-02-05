using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ObsoleteTest test = new ObsoleteTest();

            test.Method1();
            //test.Method2();
            test.Method3();

            Console.ReadKey();
        }
    }
}
