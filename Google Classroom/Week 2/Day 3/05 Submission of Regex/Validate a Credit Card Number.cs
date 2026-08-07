using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_Regex
{
    internal class Validate_a_Credit_Card_Number
    {
        public void Demo()
        {
            Console.WriteLine("Enter credit card number: ");
            string Card = Console.ReadLine();
            
            string CleanCard = Card.Replace("-", "").Replace(" ", "");
            
            string VisaPattern = @"^4\d{15}$";
            string MasterCardPattern = @"^5\d{15}$";
            
            if(Regex.IsMatch(CleanCard, VisaPattern))
                Console.WriteLine("Valid Visa card");
            else if(Regex.IsMatch(CleanCard, MasterCardPattern))
                Console.WriteLine("Valid MasterCard");
            else
                Console.WriteLine("Invalid card number");
        }
    }
}
