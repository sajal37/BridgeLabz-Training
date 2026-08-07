using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_Regex
{
    internal class Replace_Multiple_Spaces
    {
        public void Demo()
        {
            string Text = "This    is   an  example    with   multiple     spaces.";
            
            Console.WriteLine("Original:");
            Console.WriteLine(Text);
            
            string Pattern = @"\s+";
            string Result = Regex.Replace(Text, Pattern, " ");
            
            Console.WriteLine("\nAfter Replacement:");
            Console.WriteLine(Result);
        }
    }
}
