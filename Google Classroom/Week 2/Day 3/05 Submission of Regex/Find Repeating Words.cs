using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_Regex
{
    internal class Find_Repeating_Words
    {
        public void Demo()
        {
            string Text = "This is is a repeated repeated word test.";
            
            string Pattern = @"\b(\w+)\s+\1\b";
            MatchCollection Repeats = Regex.Matches(Text, Pattern, RegexOptions.IgnoreCase);
            
            Console.WriteLine("Repeating Words:");
            foreach(Match repeat in Repeats)
            {
                Console.WriteLine(repeat.Groups[1].Value);
            }
        }
    }
}
