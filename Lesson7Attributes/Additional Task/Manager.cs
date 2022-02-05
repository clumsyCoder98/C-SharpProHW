using System;

namespace Additional_Task
{
    [AccesLevel("Low")]
    class Manager : User
    {
        public Manager(string name)
            : base(name)
        {
        }
    }
}
