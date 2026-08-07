using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Actual_Work
{
    public class TemperatureConverter
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            double Fahrenheit = (celsius * 9 / 5) + 32;
            return Fahrenheit;
        }

        public double FahrenheitToCelsius(double fahrenheit)
        {
            double Celsius = (fahrenheit - 32) * 5 / 9;
            return Celsius;
        }
    }
}
