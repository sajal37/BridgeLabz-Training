using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_Regex
{
    internal class Validate_a_Username
    {
        public void Demo()
        {
            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            
            string Pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$";
            bool IsValid = Regex.IsMatch(username, Pattern);
            
            if(IsValid)
                Console.WriteLine("Valid username");
            else
                Console.WriteLine("Invalid username");
        }
    }
}
