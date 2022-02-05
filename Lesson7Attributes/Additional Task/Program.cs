using System;

namespace Additional_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new Manager("Manager");
            User user2 = new Director("Director");
            User user3 = new Programmer("Coder");

            AppLogin app = new AppLogin();
            app.Login(user1);
            app.Login(user2);
            app.Login(user3);

            Console.ReadKey();
        }
    }
}
