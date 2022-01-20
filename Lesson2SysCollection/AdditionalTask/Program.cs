using System;
using System.Collections;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList list = new SortedList();
            list.Add("a", 1);
            list.Add("c", 2);
            list.Add("b", 3);
            list.Add("d", 4);

            foreach(DictionaryEntry item in list)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine("\n" + new string ('-',30));

            SortedList list1 = new SortedList(new ReverseSort());// передаем в кач аргумента польз клас, который
            //реализует IComparer для изменения логики сортировки (сравнения)
            list1.Add("a1", 1);
            list1.Add("c1", 2);
            list1.Add("b1", 3);
            list1.Add("d1", 4);

            foreach (DictionaryEntry item1 in list1)
            {
                Console.WriteLine(item1.Key + " " + item1.Value);
            }
            Console.ReadKey();
        }
    }
}
