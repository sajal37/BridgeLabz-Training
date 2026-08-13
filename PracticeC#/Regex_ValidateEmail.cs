using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PracticeC_
{
    internal class Regex_ValidateEmail
    {
        public static void Main(string[] args)
        {
            string email = "sajal123@gmail.com";
            string pattern = @"\b[a-z0-9]+\@[a-z]+\.[a-z]+\b";
            if(Regex.IsMatch(email, pattern))
            {
                Console.WriteLine("Correct");
            } else
            {
                Console.WriteLine("Not Correct");
            }
        }
    }
}
