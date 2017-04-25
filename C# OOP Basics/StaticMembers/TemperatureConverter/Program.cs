using System;
using System.Linq;

namespace TemperatureConverter
{
    class TemperatureConverter
    {
        public static string CelsiusToFahrenheit(int degree)
        {
            return $"{degree * 9 / 5.0 + 32:F2} Fahrenheit";
        }
        public static string FahrenheitToCelsius(int degree)
        {
            return $"{(degree - 32) * 5 / 9.0:F2} Celsius";
        }
    }
    class Program
    {
        static void Main()
        {
            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (input[0] == "End")
                {
                    break;
                }
                var degree = int.Parse(input[0]);
                if (input[1] == "Celsius")
                {
                    Console.WriteLine(TemperatureConverter.CelsiusToFahrenheit(degree));
                }
                else
                {
                    Console.WriteLine(TemperatureConverter.FahrenheitToCelsius(degree));
                }
            }

        }
    }
}
