using System;


namespace Additional_Task
{
    class AppLogin
    {
        public void Login(User user)
        {
            var login = user.GetType();
            object[] accLevel = login.GetCustomAttributes(false);
            foreach (AccesLevelAttribute atr in accLevel)
            {
                if (atr.AccesLevel == "low")
                {
                    Console.WriteLine($"Hello, {user.Name}, your acces level is: Low");
                }
                if (atr.AccesLevel == "medium")
                {
                    Console.WriteLine($"Hello, {user.Name}, your acces level is: Medium");
                }
                if (atr.AccesLevel == "full")
                {
                    Console.WriteLine($"Hello, {user.Name}, your acces level is: {atr.AccesLevel}");
                }
            }
        }
    }
}
