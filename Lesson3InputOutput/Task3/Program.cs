using System;
using System.IO;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo document = new FileInfo("C:/TESTDIR/test.txt"); // тестовая строка

            FileExplorer.SearchFile("test_zip*");

            Console.WriteLine("\nShowContent test:" );
            FileExplorer.ShowContent("C:/TESTDIR/test.txt");
            FileExplorer.ShowContent(document);

            Console.WriteLine("\nCreateZip test:");
            FileExplorer.CreateZip("C:/TESTDIR/test.txt");

            Console.ReadKey();
        }
    }
}
