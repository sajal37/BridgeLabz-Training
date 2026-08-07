using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_Regex
{
    internal class Extract_Links_from_Web_Page
    {
        public void Demo()
        {
            string Text = "Visit https://www.google.com and http://example.org for more info.";
            
            string Pattern = @"https?://[^\s]+";
            MatchCollection Links = Regex.Matches(Text, Pattern);
            
            Console.WriteLine("Extracted Links:");
            foreach(Match link in Links)
            {
                Console.WriteLine(link.Value);
            }
        }
    }
}
