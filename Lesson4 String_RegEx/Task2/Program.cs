using System;
using System.Text.RegularExpressions;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new System.Net.WebClient();
            string HTML = client.DownloadString("https://auto.ria.com/uk/");

            FileInfo result = new FileInfo("result.txt");
            StreamWriter writer = result.CreateText();
            Regex pattern = null;

            pattern = new Regex(@"""https\S+"">");
            MatchCollection links = pattern.Matches(HTML);
            writer.WriteLine($"Links: {links.Count}");
            foreach (Match element in links)
            {
                writer.WriteLine(element.ToString());
            }
            writer.WriteLine();

            pattern = new Regex(@"[a-zA-Z0-9._-]+@[a-zA-Z]+\.[a-z]{2,4}");
            MatchCollection emails = pattern.Matches(HTML);
            writer.WriteLine($"E-mails: {emails.Count}");
            foreach (Match element in emails)
            {
                writer.WriteLine(element.ToString());
            }
            writer.WriteLine();

            pattern = new Regex(@"\+[-()0-9]{10,17}|0[-()0-9]{10,15}");
            MatchCollection numbers = pattern.Matches(HTML);
            writer.WriteLine($"Phone numbers: {numbers.Count}");
            foreach (Match element in numbers)
            {
                writer.WriteLine(element.ToString());
            }

            writer.Flush();
            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}
