using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    class MyClass : IDisposable
    {
        Array bytes = new int[100000000]; //318mb
        public void MethodTest()
        {
            Console.WriteLine("Test metod called");
        }

        //Формализованный шаблон очистки
        private bool disposed = false; // вызывался ли Dispose?
        public void Dispose()
        {
            CleanUp(true);//вызов вспом метода. тру значит вызвано пользователем
            
            GC.SuppressFinalize(this);// подавление финализации - отмена деструктора?
        }
        private void CleanUp(bool disposing)
        {
            if(!this.disposed)
            {
                //если диспозинг тру должно осущ. освобождение всех управляемых ресурсов
                if(disposing)
                {
                    // тут осущ. освоб управляемых ресурсов
                    Console.WriteLine("User called Dispose() worked");
                }
                // очистка неуправл ресурсов
            }
            disposed = true;
        }
        ~MyClass()
        {
            Console.WriteLine($"Object {(this).GetHashCode()} GC-called destructor worked");
            // вызов вспом метода. фолс - очистка инициирована GC
            CleanUp(false);
        }
    }
}
