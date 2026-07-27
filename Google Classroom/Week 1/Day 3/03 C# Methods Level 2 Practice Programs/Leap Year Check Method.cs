using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._03_C__Methods_Level_2_Practice_Programs
{
    internal class Leap_Year_Check_Method
    {
        public static bool IsLeapYear(int year)
        {
            if (year < 1582)
                return false;
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
        public void Demo()
        {
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year < 1582)
            {
                Console.Write("Program only works for year >= 1582.");
                return;
            }
            bool isLeap = IsLeapYear(year);
            if (isLeap)
                Console.Write($"{year} is a Leap Year");
            else
                Console.Write($"{year} is not a Leap Year");
        }
    }
}
