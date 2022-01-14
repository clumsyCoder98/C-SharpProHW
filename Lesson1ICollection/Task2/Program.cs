using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calendar test = new Calendar();
            Console.WriteLine("Indexer check:");
            Console.WriteLine(test[11].Name);

            Console.WriteLine("\nMethod check:");
            Console.WriteLine(test.FindByNumber(13).Name);

            foreach (Month item in test.SortByDays(30))
            {
                Console.WriteLine(item.Name + " " + item.Number + " " + item.Days);
            }

            Console.ReadKey();
        }
    }
}
