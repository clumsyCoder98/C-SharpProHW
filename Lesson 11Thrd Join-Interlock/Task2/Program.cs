using System;
using System.Threading;
using System.IO;

namespace Task2
{
    class Program
    {
        static object block = new object();
        static void FileWriter(object? adress)
        {
            lock (block)
            {
                string path = (string)adress;

                string content = File.ReadAllText(path);

                File.AppendAllText("Result.txt", content + "\n");
            }
        }
        static void Main(string[] args)
        {
            object adress1 = "C:/testdir/File1.txt";
            object adress2 = "C:/testdir/File2.txt";

            ParameterizedThreadStart file = new ParameterizedThreadStart(FileWriter);

            Thread thr1 = new Thread(file);
            thr1.Start(adress1);

            Thread.Sleep(100);

            Thread thr2 = new Thread(file);
            thr2.Start(adress2);

            Console.ReadKey();
        }
    }
}
