using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_Regex
{
    internal class Validate_Social_Security_Number
    {
        public void Demo()
        {
            Console.WriteLine("Enter SSN: ");
            string SSN = Console.ReadLine();
            
            string Pattern = @"^\d{3}-\d{2}-\d{4}$";
            bool IsValid = Regex.IsMatch(SSN, Pattern);
            
            Console.WriteLine(IsValid ? "Valid SSN" : "Invalid SSN");
        }
    }
}
