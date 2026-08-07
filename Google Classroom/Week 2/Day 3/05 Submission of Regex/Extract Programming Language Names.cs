using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_Regex
{
    internal class Extract_Programming_Language_Names
    {
        public void Demo()
        {
            string Text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
            
            Console.WriteLine("Programming Languages Found:");
            
            if(Regex.IsMatch(Text, @"\bJava\b"))
                Console.Write("Java ");
            if(Regex.IsMatch(Text, @"\bPython\b"))
                Console.Write("Python ");
            if(Regex.IsMatch(Text, @"\bJavaScript\b"))
                Console.Write("JavaScript ");
            if(Regex.IsMatch(Text, @"\bGo\b"))
                Console.Write("Go ");
        }
    }
}
