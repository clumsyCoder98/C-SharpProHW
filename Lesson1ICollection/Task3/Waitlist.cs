using System.Collections;
using System;
namespace Task3
{
    class Waitlist : ICollection, IEnumerable
    {
        Citizen[] list = new Citizen[0];
        private int count = 0;
        public int Count { get { return count; } }

        public Citizen this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }
        #region IEnumerable
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return list[i];
            }
        }
        #endregion

        #region ICollection
        public bool IsSynchronized
        {
            get { return false; }
        }
        public object SyncRoot
        {
            get { return null; }
        }
        public void CopyTo (Array array, int index)
        {
            list.CopyTo(array, index);
        }
        #endregion
        public void Clear()
        {
            list = new Citizen[0];
            count = 0;
            // можно оставить просто count = 0; не происходит персоздание массива, он просто
            //перезаписывается - еффективнее с тз производительности
        }
        public void Add(Citizen person)
        {
            bool add = true, addPensioner = true;

            for (int i = 0; i < count; i++)
            {
                if (person.Equals(list[i]))
                {
                    add = false;
                    addPensioner = false;
                    Console.WriteLine("Person ID already exist!");
                }
            }

            if (count > 0 && person is Pensioner && addPensioner) // добавление пенс в начало после других пенс
            {
                int position = 0;
                for (int i = 0; i < count; i++)
                {
                    if (list[i] is Pensioner)
                    {
                        position++;
                    }
                }

                Insert(person, position);
                add = false;
                Console.WriteLine($"{person.Name}, your number in line: {position+1}");
            }

            if (add)
            {
                Citizen[] newList = new Citizen[count + 1]; // count вместо list.Lenght
                list.CopyTo(newList, 0);
                newList[count] = person;
                list = newList;
                // весь блок можно было заменить на array.resize(как в Insert)
                count++;
            }
        }

        public void Insert(Citizen person, int index)
        {
            if (index <= count && index >= 0)
            {
                count++;
                Array.Resize(ref list, count);
                for (int i = count - 1; i > index; i--)// сдвиг елементов с конца на 1 до нужного индекса
                {
                    list[i] = list[i - 1];
                }
                list[index] = person;
            }
        }
        public void Remove()
        {
            if (count == 1)
            {
                list = new Citizen[0];
            }
            else
            {
                Citizen[] newList = new Citizen[count - 1];
                for (int i = count - 2; i >= 0; i--)
                {
                    newList[i] = list[i + 1];
                }
                list = newList;
            }
            count--;
        }

        public Citizen RemoveAndReturn()
        {
            Citizen removed = list[0];
            Remove();
            return removed;
        }
        public bool Contains (string search)
        {
            for (int i = 0; i < count; i++)
            {
                if(list[i].Name == search || list[i].Id == search)
                {
                    Console.WriteLine($"{search}, number in line: {i+1}");
                    return true;
                }
            }
            Console.WriteLine($"{search} - not found!");
            return false;
        }
        public Citizen ReturnLast()
        {
            Console.WriteLine($"Number in line: {count}");
            return list[count - 1];
        }
    }
}
