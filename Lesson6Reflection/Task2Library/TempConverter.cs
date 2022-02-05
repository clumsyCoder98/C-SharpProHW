using System;

namespace Task2Library
{
    public class BelowAbsoluteZeroException : Exception
    {
        public BelowAbsoluteZeroException() { }
        public BelowAbsoluteZeroException(string message)
            :base(message)
        {
        }
    }

    public class TempConverter
    {
        public double ConvertCelsius(double celsius)
        {
            if (celsius >= -273.15)
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                return fahrenheit;
            }
            else
            {
                throw new BelowAbsoluteZeroException("Temperature can't be lower than 273.15C!");
            }
        }
    }
}
