using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Actual_Work
{
    internal class validateemail
    {
        public static void Main(string[] args)
        {
            string text = "abc123@gmail.com";
            string pattern = @"\b[a-z0-9]+\@[a-z]+\.[a-z]+\b";
            Console.WriteLine(Regex.IsMatch(text, pattern));
        }
    }
}
