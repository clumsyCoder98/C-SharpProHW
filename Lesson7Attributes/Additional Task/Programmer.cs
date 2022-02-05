using System;
namespace Additional_Task
{
    [AccesLevel("Full")]
    class Programmer : User
    {
        public Programmer(string name)
            :base (name)
        {
        }
    }
}
