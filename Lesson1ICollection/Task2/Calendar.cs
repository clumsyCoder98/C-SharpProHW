using System;
using System.Collections;

namespace Task2
{
    class Calendar : IEnumerable, IEnumerator
    {
        readonly Month[]months;

        int position = -1;

        public Calendar()
        {
            months = new Month[12];
            months[0] = new Month("January", 1, 31);
            months[1] = new Month("February", 2, 28);
            months[2] = new Month("March", 3, 31);
            months[3] = new Month("April", 4, 30);
            months[4] = new Month("May", 5, 31);
            months[5] = new Month("June", 6, 30);
            months[6] = new Month("July", 7, 31);
            months[7] = new Month("August", 8, 31);
            months[8] = new Month("September", 9, 30);
            months[9] = new Month("October", 10, 31);
            months[10] = new Month("November", 11, 30);
            months[11] = new Month("December", 12, 31);
        }

        public Month this[int index]
        { 
            get
            {
                return months[index];
            }
        }
        public Month FindByNumber(int number)
        {

            for (int i = 0; i < months.Length; i++)
            {
                if (months[i].Number == number)
                {
                    return months[i];
                }
            }
            Console.WriteLine($"Wrong month number - {number}. Try again.");
            //return new Month("Error", 0, 0); так не вылетает ошибка
            return default;
        }

        public IEnumerable SortByDays(int days)
        {
            for (int i = 0; i < months.Length; i++)
            {
                if (months[i].Days == days)
                {
                    yield return months[i];
                }
            }
        }

        //IEnumerable
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        //IEnumerator
        public object Current
        {
            get
            {
                return months[position];
            }
        }

        public bool MoveNext()
        {
            if (position < months.Length - 1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
