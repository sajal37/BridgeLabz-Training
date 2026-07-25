using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Control_Flow_Level_1_Lab_Practice
{
    internal class Sum_Until_Zero_Or_Negative_Break
    {
        public void Demo()
        {
            double Total = 0.0;
            while (true)
            {
                double number = Convert.ToDouble(Console.ReadLine());
                if (number <= 0) break;
                Total += number;
            }
            Console.Write($"Total: {Total}");
        }
    }
}
