using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_Regex
{
    internal class Extract_All_Email_Addresses
    {
        public void Demo()
        {
            string Text = "Contact us at support@example.com and info@company.org";
            
            string Pattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";
            MatchCollection Emails = Regex.Matches(Text, Pattern);
            
            Console.WriteLine("Extracted Emails:");
            foreach(Match email in Emails)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}
