using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_5.Problem_Statements_for_Practice
{
    internal class Time_Zones_and_DateTimeOffset
    {
        public static void DisplayTimeZones()
        {
            DateTimeOffset now = DateTimeOffset.Now;
            DateTimeOffset gmt = DateTimeOffset.UtcNow;
            TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            DateTimeOffset ist = TimeZoneInfo.ConvertTime(now, istZone);
            DateTimeOffset pst = TimeZoneInfo.ConvertTime(now, pstZone);
            Console.WriteLine($"Current Time (Local): {now}");
            Console.WriteLine($"GMT Time: {gmt}");
            Console.WriteLine($"IST Time: {ist}");
            Console.Write($"PST Time: {pst}");
        }
        public void Demo()
        {
            DisplayTimeZones();
        }
    }
}
