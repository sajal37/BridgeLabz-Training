using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._04_C__Methods_Level_3_Practice_Programs
{
    internal class Display_Month_Calendar
    {
        public static string GetMonthName(int m)
        {
            string[] months = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            return months[m];
        }
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
        public static int GetDaysInMonth(int m, int y)
        {
            int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (m == 2 && IsLeapYear(y))
                return 29;
            return days[m];
        }
        public static int GetFirstDayOfMonth(int m, int y)
        {
            int d = 1;
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + (31 * m0) / 12) % 7;
            return d0;
        }
        public void Demo()
        {
            Console.WriteLine("Enter month (1-12) and year: ");
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());
            string monthName = GetMonthName(month);
            int totalDays = GetDaysInMonth(month, year);
            int firstDay = GetFirstDayOfMonth(month, year);
            Console.WriteLine($"{monthName} {year}");
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
            for (int i = 0; i < firstDay; i++)
            {
                Console.Write("    ");
            }
            for (int day = 1; day <= totalDays; day++)
            {
                Console.Write($"{day,3} ");
                if ((day + firstDay) % 7 == 0 || day == totalDays)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
