using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PracticeC_
{
    internal class Regex_ValidatePhoneNumber
    {
        public static void Main(string[] args)
        {
            string num = "8623947108";
            string pattern = @"\b[6-9]\d{9}\b";
            if (Regex.IsMatch(num, pattern))
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Not Correct");
            }
        }
    }
}
