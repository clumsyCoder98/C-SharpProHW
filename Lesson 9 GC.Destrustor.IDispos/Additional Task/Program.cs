using System;
using System.Threading;

namespace Additional_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass[] classes = new MyClass[20];
            for (int i = 0; i < classes.Length; i++)
            {
                //classes[i] = new MyClass(); // так вылетает outmemoryExc
                MyClass myclass = new MyClass(); // вызывается деструктор GC
                Console.WriteLine($"{myclass.GetHashCode()} created");
                Thread.Sleep(100);
            }

            GC.WaitForPendingFinalizers();


            Thread.Sleep(1000);
            Console.WriteLine(new string('-', 50));

            MyClass instance = new MyClass();
            using (instance = new MyClass()) // так вызывается пользовательский Dispose
            {
                instance.MethodTest();
            }
            instance.Dispose();// тут уже не вызывается, тк паттерн предусматривает защиту от повторного вызова.
            Console.ReadKey();
        }
    }
}
