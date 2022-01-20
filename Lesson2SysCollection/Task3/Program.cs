using System;
using System.Collections;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountTotal test = new AccountTotal();
            test.Add(123, 32.4m);
            test.Add(123, 37.4m);
            test.Add(257, 101.47678m);
            test.Add(801, 1256.0987m);
            test.Add(34, 7.7777m);

            Console.WriteLine(test.Count);

            foreach (var item in test)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
