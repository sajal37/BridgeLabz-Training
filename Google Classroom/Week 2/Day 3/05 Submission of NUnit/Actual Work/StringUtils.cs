using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Actual_Work
{
    public class StringUtils
    {
        public string Reverse(string str)
        {
            if (str == null)
                return null;
            char[] Chars = str.ToCharArray();
            Array.Reverse(Chars);
            string Reversed = new string(Chars);
            return Reversed;
        }

        public bool IsPalindrome(string str)
        {
            if (str == null)
                return false;
            string Rev = Reverse(str);
            bool IsPalin = str.Equals(Rev);
            return IsPalin;
        }

        public string ToUpperCase(string str)
        {
            if (str == null)
                return null;
            string Upper = str.ToUpper();
            return Upper;
        }
    }
}
