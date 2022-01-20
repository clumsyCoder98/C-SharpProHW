using System;
using System.Collections;
using System.Collections.Specialized;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedDictionary test = new OrderedDictionary(new KeyComparer());
            string key1 = "1";
            string key2 = "1";
            test[key1] = 1;
            test[key2] = 2;

            test["two"] = 3;
            test["TwO"] = 4;

            Console.WriteLine(test.Count);
            Console.ReadKey();
        }
    }

    class KeyComparer : IEqualityComparer // так понимаю работает только со строчным индексом(тк числовой - ошибка)
    {
        CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

        public new bool Equals(object x, object y)
        {
            return comparer.Compare(x, y) == 0;
        }

        public int GetHashCode(object obj)
        {
            return obj.ToString().ToLowerInvariant().GetHashCode();
        }
    }
}
