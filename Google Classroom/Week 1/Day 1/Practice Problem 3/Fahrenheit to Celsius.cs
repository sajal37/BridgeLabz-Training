using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_3
{
    internal class Fahrenheit_to_Celsius
    {
        public void Demo()
        {
            Console.Write("Enter Fahrenheit: ");
            double f = Convert.ToDouble(Console.ReadLine());
            double c = (f - 32.0) * 5.0 / 9.0;
            Console.WriteLine($"Celsius: {c}");
        }
    }
}
