using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_5.Problem_Statements_for_Practice
{
    internal class Date_Arithmetic
    {
        public static DateTime PerformDateArithmetic(DateTime inputDate)
        {
            DateTime addedDate = inputDate.AddDays(7).AddMonths(1).AddYears(2);
            DateTime finalDate = addedDate.AddDays(-21);
            return finalDate;
        }
        public void Demo()
        {
            Console.Write("Enter date (yyyy-MM-dd): ");
            DateTime inputDate = Convert.ToDateTime(Console.ReadLine());
            DateTime result = PerformDateArithmetic(inputDate);
            Console.WriteLine($"Original Date: {inputDate:yyyy-MM-dd}");
            Console.Write($"Final Date: {result:yyyy-MM-dd}");
        }
    }
}
