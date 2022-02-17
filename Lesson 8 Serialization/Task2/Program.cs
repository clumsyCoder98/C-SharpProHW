using System;
using System.Xml.Serialization;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            XMLtest tester = new XMLtest();
            tester.name = "First";
            tester.surname = "Test";
            tester.country = "Ukraine";

            FileStream stream = new FileStream("XMLtester.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(XMLtest));
            serializer.Serialize(stream, tester);
            stream.Close();

            Console.WriteLine("Start deserialization: press any key");
            Console.ReadKey();

            stream = new FileStream("XMLtester.xml", FileMode.Open);
            serializer = new XmlSerializer(typeof(XMLtest));
            XMLtest item = (XMLtest)serializer.Deserialize(stream);

            Console.WriteLine(item.name + item.surname + item.country);
            Console.ReadKey();
        }
    }
}
