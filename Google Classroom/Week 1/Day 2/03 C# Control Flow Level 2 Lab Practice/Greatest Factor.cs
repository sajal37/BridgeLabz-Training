using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._03_C__Control_Flow_Level_2_Lab_Practice
{
    internal class Greatest_Factor
    {
        public void Demo()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int greatestFactor = 1;
            for (int i = number - 1; i >= 1; i--)
            {
                if (number % i == 0)
                {
                    greatestFactor = i;
                    break;
                }
            }
            Console.Write($"Greatest factor beside itself: {greatestFactor}");
        }
    }
}
