using System;
using System.IO;
using System.Text.RegularExpressions;


namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("C:/testdir/receipt.txt");
            Console.WriteLine($"Исходный вид:\n{content}");
            Console.WriteLine(new string('-',50));

            string result = Regex.Replace(content, @"\b(?<integer>\d+),(?<decimal>\d+)\b", "${integer}.${decimal}");
            result = Regex.Replace(result, @"\b(?<day>\d{2})/(?<months>\d{2})/(?<year>\d{2,4})\b", "${months}/${day}/${year}");
            Console.WriteLine($"en-US вид:\n{result}");

            Console.ReadKey();
        }
    }
}
