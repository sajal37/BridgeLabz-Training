using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._03_C__Control_Flow_Level_2_Lab_Practice
{
    internal class Leap_Year_Single_If
    {
        public void Demo()
        {
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year >= 1582)
            {
                bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
                if (isLeap)
                    Console.Write($"{year} is a Leap Year");
                else
                    Console.Write($"{year} is not a Leap Year");
            }
        }
    }
}
