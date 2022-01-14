using System;

namespace Task2
{
    class Month
    {
        public string Name { get; }
        public int Number { get; }
        public int Days { get; }

        public Month(string name, int number, int days)
        {
            Name = name;
            Number = number;
            Days = days;
        }
    }
}
