using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;

namespace Task3
{
    class AutoTranslator
    {
        // заменяет вся слова от 1 до 3 букв (- не всегда предлог)
        public void AutoTranslate(string path)
        {
            string content = File.ReadAllText(path, Encoding.Unicode);
            Console.WriteLine($"Исходный текст: {content}");

            const string PATTERN = @"\b[а-яА-Я]{1,4}\b";
            string result = Regex.Replace(content, PATTERN, "ГАВ!");
            Console.WriteLine($"Результат: {result}");

            File.WriteAllText(path, result, Encoding.Unicode);

            Console.WriteLine("File changed");
        }
    }
}
