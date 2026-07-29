using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_5.Problem_Statements_for_Practice
{
    internal class Date_Comparison
    {
        public static int CompareDates(DateTime date1, DateTime date2)
        {
            return DateTime.Compare(date1, date2);
        }
        public void Demo()
        {
            Console.Write("Enter first date (yyyy-MM-dd): ");
            DateTime date1 = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter second date (yyyy-MM-dd): ");
            DateTime date2 = Convert.ToDateTime(Console.ReadLine());
            int result = CompareDates(date1, date2);
            if (result < 0)
                Console.Write($"{date1:yyyy-MM-dd} is before {date2:yyyy-MM-dd}");
            else if (result > 0)
                Console.Write($"{date1:yyyy-MM-dd} is after {date2:yyyy-MM-dd}");
            else
                Console.Write($"{date1:yyyy-MM-dd} is the same as {date2:yyyy-MM-dd}");
        }
    }
}
