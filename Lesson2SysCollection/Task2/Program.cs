using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cu1 = new Customer("cu1");
            Customer cu2 = new Customer("cu2");
            Customer cu3 = new Customer("cu3");

            Product pro1 = new Product("pro1");
            Product pro2 = new Product("pro2");
            Product pro3 = new Product("pro3");

            Console.WriteLine(cu1.GetHashCode());
            Console.WriteLine(cu2.GetHashCode());
            Console.WriteLine(cu1.Equals(cu3));


            CustomerProductList test = new CustomerProductList();

            test.Add(cu1, pro1);
            test.Add(cu2, pro2);
            test.Add(cu3, pro3);
            test.Add(cu1, pro3);
            test.Add(cu2, pro1);
            test.Add(cu3, pro2);
            Console.WriteLine(test.Count);

            Console.WriteLine("\nFindByName test" + "\n" + new string('-', 30));

            Product[] test1 = test.FindByName("cu1");

            for (int i = 0; i < test1.Length; i++)
            {
                Console.WriteLine(test1[i].Category);
            }

            Console.WriteLine("\nShowCustomers test" + "\n" + new string('-', 30));
            Customer[] test2 = test.ShowCustomers(pro1);
            for (int i = 0; i < test2.Length; i++)
            {
                Console.WriteLine(test2[i].Name);
            }

            Console.WriteLine("\nShowProducts test" + "\n" + new string('-', 30));
            Product[] test3 = test.ShowProducts(cu3);
            for (int i = 0; i < test3.Length; i++)
            {
                Console.WriteLine(test3[i].Category);
            }

            Console.WriteLine("\nforeach test" + "\n" + new string('-', 30));
            foreach (KeyValuePair<Customer, List<Product>> item in test)
            {
                Console.WriteLine(item.Key.Name);
                Product[] values = item.Value.ToArray();
                for (int j = 0; j < values.Length; j++)
                {
                    Console.WriteLine(values[j].Category);
                }
            }

            Console.ReadKey();
        }
    }
}
