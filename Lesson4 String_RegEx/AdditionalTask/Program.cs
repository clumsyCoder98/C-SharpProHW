using System;
using System.Text.RegularExpressions;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter your login: ");
                string logInput = Console.ReadLine();

                const string LOG_PATTERN = @"^[A-Za-z]+$";
                Regex loginLook = new Regex(LOG_PATTERN);
                bool logCheck = loginLook.IsMatch(logInput);

                if (logCheck)
                {
                    Console.WriteLine("Loggin accepted");
                    break;
                }
                else
                {
                    Console.WriteLine("Login can contain only albhabetic characters.");
                }
            }

            while (true)
            {
                Console.Write("Enter your password: ");
                string passInput = Console.ReadLine();

                const string PASS_PATTERN = @"((?=\w*\d)(?=\w*[a-zA-Z])(\w{5,15}))"; // должна быть мин 1 цифра, мин 1 буква, длинна от 5 до 15
                Regex passLook = new Regex(PASS_PATTERN);
                bool passCheck = passLook.IsMatch(passInput);

                if (passCheck)
                {
                    Console.WriteLine("Password accepted");
                    break;
                }
                else
                {
                    Console.WriteLine("Password can contain only numbers and albpabetic characters. " +
                        "Password lengt must be at least 5 symbols.");
                }
            }
            Console.ReadKey();
        }
    }
}
