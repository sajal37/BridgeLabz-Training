using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_Regex
{
    internal class Extract_Currency_Values
    {
        public void Demo()
        {
            string Text = "The price is $45.99, and the discount is $ 10.50.";
            
            string Pattern = @"\$\s*\d+\.\d{2}";
            MatchCollection Values = Regex.Matches(Text, Pattern);
            
            Console.WriteLine("Extracted Currency Values:");
            foreach(Match val in Values)
            {
                Console.WriteLine(val.Value.Trim());
            }
        }
    }
}
