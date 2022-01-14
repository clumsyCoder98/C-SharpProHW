using System;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            CollectionCreator testCollection = new CollectionCreator();
            foreach (int item in testCollection.CreateCollection(testArray))
            {
                Console.WriteLine(item);
            }

            // или так
            Console.WriteLine(new string('-',30));

            var example = testCollection.CreateCollection(testArray);
            foreach (int number in example)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
