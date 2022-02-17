using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Additional_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass("Tester", 24);
            #region Serialization
            Stream stream = File.Create("Tester.dat");

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, test);

            stream.Close();
            #endregion

            #region DeSerialization
            stream = File.OpenRead("Tester.dat");
            test = (TestClass)formatter.Deserialize(stream);
            Console.WriteLine(test.name + " " + test.age + " " + test.nameAge);
            stream.Close();
            #endregion
            Console.ReadKey();
        }
    }
}
