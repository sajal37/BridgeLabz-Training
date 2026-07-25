using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._03_C__Control_Flow_Level_2_Lab_Practice
{
    internal class Leap_Year_Multiple_If
    {
        public void Demo()
        {
            int year = Convert.ToInt32(Console.ReadLine());
            if (year >= 1582)
            {
                if (year % 400 == 0)
                    Console.Write($"{year} is a Leap Year");
                else if (year % 100 == 0)
                    Console.Write($"{year} is not a Leap Year");
                else if (year % 4 == 0)
                    Console.Write($"{year} is a Leap Year");
                else
                    Console.Write($"{year} is not a Leap Year");
            }
        }
    }
}
