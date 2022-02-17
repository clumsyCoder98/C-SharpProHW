using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    class BaseClass
    {
        //NVI - паттерн;
        public void UserMetod()
        {
            InnerMethod();
            InnerMethod2();
        }
        protected virtual void InnerMethod()
        {
            Console.WriteLine("InnMeth1. Base. This method can be edited!");
        }

        protected virtual void InnerMethod2()
        {
            Console.WriteLine("InnMeth2. Base. 2nd method");
        }
    }
}
