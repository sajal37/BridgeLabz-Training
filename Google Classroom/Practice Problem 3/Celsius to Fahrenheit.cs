using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_3
{
    internal class Celsius_to_Fahrenheit
    {
        public void Demo()
        {
            Console.Write("Enter Celsius: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double f = (c * 9.0 / 5.0) + 32.0;
            Console.WriteLine($"Fahrenheit: {f}");
        }
    }
}
