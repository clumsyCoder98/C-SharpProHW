using System;
using System.Collections;
using System.Collections.Generic;
namespace Task2
{
    class CustProdListRemake : ICollection, IEnumerable, IEnumerator
    {
        // добавлена реализация IEnumerator, изменена логика GetEnumerator()
        private int count = 0;

        Customer[] customers = new Customer[0];
        List<Product>[] categories = new List<Product>[0];

        #region ICollection
        public int Count { get { return count; } }
        public bool IsSynchronized { get { return false; } }
        public object SyncRoot { get { return null; } }
        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region IEnumerator
        int position = -1;
        public object Current
        {
            get { return new KeyValuePair<Customer, List<Product>>(customers[position], categories[position]); }
        }
        public bool MoveNext()
        {
            if (position < Count-1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }
        public void Reset()
        {
            position = -1;
        }
        #endregion
        public IEnumerator GetEnumerator()// работает так-же как оригинал, другая реализация
        {
            return this;
        }
        public void Add(Customer name, Product category)
        {
            if (Count > 0)
            {
                bool newPair = true;

                for (int i = 0; i < Count; i++) // проверка на повторное имя
                {
                    if (name.Equals(customers[i]))
                    {
                        categories[i].Add(category);
                        newPair = false;
                        break;
                    }
                }

                if (newPair)
                {
                    Array.Resize(ref customers, Count + 1);
                    customers[Count] = name;

                    Array.Resize(ref categories, Count + 1);
                    categories[Count] = new List<Product>();
                    categories[Count].Add(category);
                    count++;
                }
            }

            if (Count == 0)
            {
                // можно заменить на Array.Resize как выше
                Customer[] tempCustomer = new Customer[Count + 1];
                List<Product>[] tempCategories = new List<Product>[Count + 1];

                tempCustomer[Count] = name;
                tempCategories[Count] = new List<Product>();
                tempCategories[Count].Add(category);

                customers = tempCustomer;
                categories = tempCategories;

                count++;
            }
        }
        public Product[] FindByName(string name)
        {
            Product[] products = new Product[0];
            for (int i = 0; i < Count; i++)
            {
                if (name == customers[i].Name)
                {
                    products = categories[i].ToArray();
                    break;
                }
            }
            return products;
        }

        public Product[] ShowProducts(Customer name)
        {
            Product[] products = new Product[0];
            for (int i = 0; i < Count; i++)
            {
                if (customers[i].Equals(name))
                {
                    products = categories[i].ToArray();
                    break;
                }
            }
            return products;
        }

        public Customer[] ShowCustomers(Product product)
        {
            Customer[] users = new Customer[0];
            for (int i = 0; i < Count; i++)
            {
                if (categories[i].Contains(product))
                {
                    Array.Resize(ref users, users.Length + 1);
                    users[users.Length - 1] = customers[i];
                }
            }
            return users;
        }
    }
}
