using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_5.Problem_Statements_for_Practice
{
    internal class Date_Formatting
    {
        public static void DisplayFormattedDates()
        {
            DateTime currentDate = DateTime.Now;
            string format1 = currentDate.ToString("dd/MM/yyyy");
            string format2 = currentDate.ToString("yyyy-MM-dd");
            string format3 = currentDate.ToString("ddd, MMM dd, yyyy");
            Console.WriteLine($"Format 1 (dd/MM/yyyy): {format1}");
            Console.WriteLine($"Format 2 (yyyy-MM-dd): {format2}");
            Console.Write($"Format 3 (EEE, MMM dd, yyyy): {format3}");
        }
        public void Demo()
        {
            DisplayFormattedDates();
        }
    }
}
