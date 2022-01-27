using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;


namespace Task3
{
    class ManualTranslator
    {
        // вариант с точным определением предлогов, но нужно прописать все вручную
        List<string> swapWords = new List<string> { "без", "близ", "вместо", "в", "вне", "для", "до", "за", "из", "к", "на", "под" };
        public void Translate(string path)
        {
            FileStream source = File.OpenRead(path);
            StreamReader read = new StreamReader(source,Encoding.Unicode);
            string content = read.ReadToEnd();
            read.Close();

            Console.WriteLine($"Исходный текст: {content}");

            foreach (string word in swapWords)
            {
                content = Regex.Replace(content, $@"\b{word}\b", "ГАВ!");
            }

            Console.WriteLine($"Результат: {content}");

            source = File.OpenWrite(path);
            StreamWriter write = new StreamWriter(source, Encoding.Unicode);
            write.Write(content);
            write.Close();

            Console.WriteLine("File changed");
        }
    }
}
