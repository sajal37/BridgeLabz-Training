using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_Regex
{
    internal class Validate_a_License_Plate_Number
    {
        public void Demo()
        {
            Console.WriteLine("Enter license plate number: ");
            string Plate = Console.ReadLine();
            
            string Pattern = @"^[A-Z]{2}\d{4}$";
            bool IsValid = Regex.IsMatch(Plate, Pattern);
            
            Console.WriteLine(IsValid ? "Valid" : "Invalid");
        }
    }
}
