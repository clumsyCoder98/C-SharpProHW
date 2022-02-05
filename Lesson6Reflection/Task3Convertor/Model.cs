using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Task3Convertor
{
    class Model
    {
        public double Convertor(string temp)
        {
            string input = Regex.Replace(temp, @"(?<integer>\d+)\.(?<decimal>\d+)", "${integer},${decimal}");
            double celsius = double.Parse(input);

            Assembly task2Lib = Assembly.LoadFrom(@"C:/testdir/Task2Library.dll");
            Type type = task2Lib.GetType("Task2Library.TempConverter");
            object instance = Activator.CreateInstance(type);
            MethodInfo method = type.GetMethod("ConvertCelsius");
            object result = method.Invoke(instance, new object[] {celsius});

            double fahrenheit = Convert.ToDouble(result);
            return fahrenheit;
        }
    }
}
