using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_5.Problem_Statment
{
    internal class Temperature_Converter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        public void Demo()
        {
            Console.Write("Enter Fahrenheit temperature: ");
            double f = Convert.ToDouble(Console.ReadLine());
            double celsius = FahrenheitToCelsius(f);
            Console.WriteLine($"{f} F = {celsius} C");
            Console.Write("Enter Celsius temperature: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = CelsiusToFahrenheit(c);
            Console.Write($"{c} C = {fahrenheit} F");
        }
    }
}
