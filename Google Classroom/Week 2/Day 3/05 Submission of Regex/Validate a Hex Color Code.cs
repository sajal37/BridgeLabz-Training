using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_Regex
{
    internal class Validate_a_Hex_Color_Code
    {
        public void Demo()
        {
            Console.Write("Enter hex color code: ");
            string Color = Console.ReadLine();
            
            string Pattern = @"^#[0-9A-Fa-f]{6}$";
            
            if(Regex.IsMatch(Color, Pattern))
                Console.WriteLine("Valid hex color");
            else
                Console.WriteLine("Invalid hex color");
        }
    }
}
