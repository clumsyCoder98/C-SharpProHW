using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    class DerivedClass : BaseClass
    {
        protected override void InnerMethod()
        {
            Console.WriteLine("InnMeth1. Metod was overriden in derived class");
        }
        new protected void InnerMethod2()
        {
            Console.WriteLine("InnMeth2. Was replaced using New in derived class");
        }
    }
}
