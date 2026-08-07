using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_Regex
{
    internal class Extract_Dates_in_Format
    {
        public void Demo()
        {
            string Text = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";
            
            string Pattern = @"\b\d{2}/\d{2}/\d{4}\b";
            MatchCollection Dates = Regex.Matches(Text, Pattern);
            
            Console.WriteLine("Extracted Dates:");
            foreach(Match date in Dates)
            {
                Console.WriteLine(date.Value);
            }
        }
    }
}
