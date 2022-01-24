using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new FileInfo(@"./Test2.txt");

            StreamWriter write = file.CreateText();
            write.WriteLine("hello world");
            write.Write(write.NewLine);
            write.WriteLine("info added");

            Console.WriteLine($"Added new data to {file.Name}");
            Console.WriteLine($"Press key to close: {file.Name}");
            Console.ReadKey();

            write.Close();

            Console.WriteLine($"{file.Name} closed");
            Console.WriteLine($"Press key to open and read: {file.Name}");
            Console.ReadKey();

            StreamReader read = File.OpenText(@"./Test2.txt");
            string input;

            while ((input = read.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }
            read.Close();

            Console.ReadKey();
        }
    }
}
