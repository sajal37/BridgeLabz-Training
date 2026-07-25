using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_1
{
    internal class Celsius_to_Fahrenheit_Conversion
    {
        public void Demo()
        {
            int Celsius = Convert.ToInt32(Console.ReadLine());
            int Fahrenheit = (Celsius * 9 / 5) + 32;
            Console.WriteLine(Fahrenheit);
        }
    }
}
