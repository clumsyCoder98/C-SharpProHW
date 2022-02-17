using System;

namespace Additional_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass base1 = new BaseClass();
            base1.UserMetod();

            Console.WriteLine(new string('-',50));
            BaseClass base2 = new DerivedClass(); //UpCast (привели к Derived)
            base2.UserMetod();

            Console.WriteLine(new string('-', 50));
            BaseClass base3 = base2;// Downcast(вернули к Base);
                                    // override метод сохраняет свой функционал из derived класса
            base3.UserMetod();

            Console.WriteLine(new string('-', 50));
            DerivedClass der1 = new DerivedClass();
            der1.UserMetod(); // тут не отработает new метод из derived класса, тк UserMeth из базового, а new
                              // не меняла его реализацию

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Derived2:\n");
            BaseClass der2 = new DerivedClass2(); //UpCast привели к Derived2, new не отрабатывают.
            der2.UserMetod();

            Console.WriteLine(new string('-', 50));
            BaseClass der21 = der2;
            der21.UserMetod(); //DownCast.

            Console.WriteLine(new string('-', 50));
            DerivedClass2 der22 = new DerivedClass2();
            der22.UserMetod(); //тут отработают все new, тк мы сразу определяем его как DerCl2, а не во время
                               //выполнения.

            // new не переписывает логику метода из базового класса, но замещает его. Это как новый метод для
            // конкретного типа наследника, и отработает он только при указании наследника как исходного типа
            // (derived = derived)
            // но не при определении во время выполнения(base=derived)

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("DeriveD from Derived2\n");
            DerivedClass2 dd1 = new DerivedFromD2();
            dd1.UserMetod();
            DerivedFromD2 dd2 = new DerivedFromD2();
            dd2.UserMetod();
            // наследник2 наследника1 сразу будет реализовать new методы прописаные в наследнике1 (если наследник1
            // не имеет ссылок на вызов базовых методов

            Console.ReadKey();
        }
    }
}
