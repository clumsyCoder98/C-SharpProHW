using System;
namespace Task2
{
    class MemoryController
    {
        private int restiction;
        public MemoryController(int restrictionKB)
        {
            restiction = restrictionKB;
        }
        public void ShowStatus()
        {
            long memoryUsed = GC.GetTotalMemory(false) / 1024;

            if(memoryUsed > restiction)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Memory limit exceeded. Used {memoryUsed} out of {restiction}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Total memory used: {memoryUsed} out of {restiction}");
            }
            Console.ResetColor();
        }
    }
}
