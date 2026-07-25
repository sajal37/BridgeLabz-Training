using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._04_C__Control_Flow_Level_3_Lab_Practice
{
    internal class Day_Of_Week
    {
        public void Demo()
        {
            Console.WriteLine("Enter month (1-12), day (1-31), year: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + (31 * m0) / 12) % 7;
            Console.Write($"Day of the week: {d0}");
        }
    }
}
