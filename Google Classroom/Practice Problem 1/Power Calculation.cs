using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_1
{
    internal class Power_Calculation
    {
        public void Demo()
        {
            Console.WriteLine("Enter base and exponent: ");
            int baseValue = Convert.ToInt32(Console.ReadLine());
            int exponent = Convert.ToInt32(Console.ReadLine());
            double result = Math.Pow(baseValue, exponent);
            Console.Write($"Result: {result}");
        }
    }
}
