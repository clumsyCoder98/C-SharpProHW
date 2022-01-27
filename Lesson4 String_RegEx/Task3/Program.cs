using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            new ManualTranslator().Translate("C:/testdir/translate.txt");

            Console.WriteLine(new string('-',50));

            new AutoTranslator().AutoTranslate("C:/testdir/translate.txt");
            Console.ReadKey();
        }
    }
}
