using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_Regex
{
    internal class Validate_an_IP_Address
    {
        public void Demo()
        {
            Console.Write("Enter IP address: ");
            string IP = Console.ReadLine();
            
            string Pattern = @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            
            if(Regex.IsMatch(IP, Pattern))
                Console.WriteLine("Valid IP address");
            else
                Console.WriteLine("Invalid IP address");
        }
    }
}
