using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Control_Flow_Level_1_Lab_Practice
{
    internal class Sum_Until_Zero_While
    {
        public void Demo()
        {
            double Total = 0.0;
            double number = Convert.ToDouble(Console.ReadLine());
            while (number != 0)
            {
                Total += number;
                number = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write($"Total: {Total}");
        }
    }
}
