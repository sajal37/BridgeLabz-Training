using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Actual_Work
{
    public class DateFormatter
    {
        public string FormatDate(string inputDate)
        {
            try
            {
                DateTime Date = DateTime.ParseExact(inputDate, "yyyy-MM-dd", null);
                string Formatted = Date.ToString("dd-MM-yyyy");
                return Formatted;
            }
            catch (FormatException)
            {
                throw new ArgumentException("Invalid date format");
            }
        }
    }
}
