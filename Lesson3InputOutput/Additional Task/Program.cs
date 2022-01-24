using System;
using System.IO;

namespace Additional_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo current = new DirectoryInfo(@".");
            Console.WriteLine($"Directory name: {current.FullName}");
            for (int i = 0; i < 100; i++)
            {
                current.CreateSubdirectory("Sub" + i);
            }
            DirectoryInfo[] subDir = current.GetDirectories("Sub*");
            Console.WriteLine($"SubDirectories number: {subDir.Length}");

            Console.WriteLine($"Press key to remove SubDirectories");
            Console.ReadKey();

            for (int i = 0; i < subDir.Length; i++)
            {
                Directory.Delete("./Sub" + i); // удалить в текущей с именем Sub0, Sub1 ... Sub(i)
            }

            subDir = current.GetDirectories("Sub*");
            Console.WriteLine($"SubDirectories number: {subDir.Length}");

            Console.ReadKey();
        }
    }
}
