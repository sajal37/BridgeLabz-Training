using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PracticeC_
{
    internal class Regex_ExtractNumbers
    {
        public static void Main(string[] args)
        {
            string text = "I have 25 apples, 10 bananas and 50 oranges.";
            string pattern = @"\b\d+\b";
            MatchCollection matches = Regex.Matches(text, pattern);
            foreach(Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
