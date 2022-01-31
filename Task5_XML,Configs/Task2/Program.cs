using System;
using System.Xml;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextReader reader = new XmlTextReader("bench.xml");

            while (reader.Read())
            {
                Console.WriteLine($"NodeType: {reader.NodeType.ToString()}");
                Console.WriteLine($"Name: {reader.Name}");
                Console.WriteLine($"Value: {reader.Value}");
            }

            reader.Close();
            Console.ReadKey();
        }
    }
}
