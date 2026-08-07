using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_Regex
{
    internal class Censor_Bad_Words
    {
        public void Demo()
        {
            string Text = "This is a damn bad example with some stupid words.";
            
            Console.WriteLine("Original:");
            Console.WriteLine(Text);
            
            string Result = Text;
            Result = Regex.Replace(Result, @"\bdamn\b", "****", RegexOptions.IgnoreCase);
            Result = Regex.Replace(Result, @"\bstupid\b", "****", RegexOptions.IgnoreCase);
            
            Console.WriteLine("\nCensored:");
            Console.WriteLine(Result);
        }
    }
}
