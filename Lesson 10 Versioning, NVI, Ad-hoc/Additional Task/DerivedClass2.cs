using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    class DerivedClass2 : BaseClass
    {
        new public void UserMetod()
        {
            Console.WriteLine("new User method from DerivedClass2!");
            InnerMethod();
            InnerMethod2();
        }
        protected override void InnerMethod()
        {
            Console.WriteLine("InnMeth1. Der2. Overriden in derived2");
        }

        new protected void InnerMethod2() // чтобы работало замещение нужно заместить в тч UserMetod,
                                          // чтоб он не вызывался из базового класса
        {
            Console.WriteLine("InnMeth2. Der2. using new in DerivedClass2");
        }
    }
}
