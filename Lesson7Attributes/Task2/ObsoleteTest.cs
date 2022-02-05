using System;
using System.Reflection;

namespace Task2
{
    [Obsolete("This is old class!")]
    class ObsoleteTest
    {
        [Obsolete("Method1 show a message")]
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        [Obsolete("Method2 stops compilation", error:true)]
        public void Method2()
        {
            Console.WriteLine("Method2");
        }
        [Obsolete("Meth3 show his attribute")]
        public void Method3()
        {
            Type type = this.GetType();
            var method = type.GetMethod("Method3");
            var attr = method.GetCustomAttributes(false);
            foreach (ObsoleteAttribute item in attr)
            {
                Console.WriteLine(item.GetType());
                Console.WriteLine(item.Message);
            }
        }

    }
}
