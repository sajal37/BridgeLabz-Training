using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace Google_Classroom.Week_5.Day_2._01_02_Submission_of_JSON
{
    internal class Validate_an_Email_Field_Using_JSON_Schema
    {
        public static void Main(string[] args)
        {
            string json = "{\"username\": \"john_doe\", \"email\": \"john.doe@domain.com\"}";
            JObject obj = JObject.Parse(json);
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string email = (string)obj["email"];
            bool isValid = !string.IsNullOrEmpty(email) && Regex.IsMatch(email, emailPattern);
            if (isValid) Console.WriteLine($"Valid Email: {email}");
            else Console.WriteLine($"Invalid Email: {email}");
        }
    }
}
