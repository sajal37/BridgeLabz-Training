using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_Regex
{
    internal class Extract_All_Capitalized_Words
    {
        public void Demo()
        {
            string Text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
            
            string Pattern = @"\b[A-Z][a-z]*\b";
            MatchCollection Words = Regex.Matches(Text, Pattern);
            
            Console.Write("Capitalized Words: ");
            foreach(Match word in Words)
            {
                Console.Write(word.Value + " ");
            }
        }
    }
}
