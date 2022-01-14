using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizen pension = new Pensioner("Pen", "1");
            Citizen work = new Worker("Wor", "2");
            Citizen stud = new Student("Stu", "3");
            Citizen pension1 = new Pensioner("Pen1", "11");
            Citizen pension2 = new Pensioner("Pen2", "111");
            Citizen work1 = new Worker("Wor1", "22");
            Citizen stud1 = new Student("Stud1", "33");
            Console.WriteLine(stud.Name);
            Console.WriteLine(pension.Equals(stud));
            Console.WriteLine(pension.GetHashCode());
            Console.WriteLine(stud.GetHashCode());

            
            Waitlist test = new Waitlist();

            
            test.Add(pension);
            test.Add(pension2);
            test.Add(stud1);
            test.Add(work);
            test.Add(pension1);
            test.Add(stud);


            Console.WriteLine(test[0].Name);
            Console.WriteLine(test[1].Name);
            Console.WriteLine(test[2].Name);
            Console.WriteLine(test[3].Name);
            Console.WriteLine(test[4].Name);
            Console.WriteLine(test[5].Name);
            Console.WriteLine($"Count: {test.Count}");

            Console.WriteLine("\nRemove test");
            test.Remove();
            Console.WriteLine($"Count: {test.Count}");
            Console.WriteLine($"[0] index name: {test[0].Name}");

            Console.WriteLine("\nReturnAndRemove test");
            Citizen removed = test.RemoveAndReturn();
            Console.WriteLine($"Removed name: {removed.Name}");
            Console.WriteLine($"Count: {test.Count}");
            Console.WriteLine($"[0] index name: {test[0].Name}");
            Console.WriteLine($"Last index name: {test[3].Name}");

            Console.WriteLine("\nContains test");
            Console.WriteLine(test.Contains("Stud1"));
            test.Contains("2"); // без writeline не выводится true/false в консоль
            Console.WriteLine(test.Contains("Pen"));

            Console.WriteLine("\nReturnLast() test");
            Citizen last = test.ReturnLast();
            Console.WriteLine(last.Name);

            Console.WriteLine("\nforeach test");
            foreach(Citizen element in test)
            {
                Console.WriteLine(element.Name);
            }

            Console.WriteLine("\nCopyTo test");
            Citizen []testArray = new Citizen[5];
            testArray[0] = work1;

            test.CopyTo(testArray, 1);
            for (int i = 0; i < testArray.Length; i++)
            {
                Console.WriteLine(testArray[i].Name);
            }

            Console.ReadKey();

        }
    }
}
