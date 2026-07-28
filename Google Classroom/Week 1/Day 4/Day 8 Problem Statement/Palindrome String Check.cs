using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_4.Day_8_Problem_Statement
{
    internal class Palindrome_String_Check
    {
        public static bool IsPalindrome(string str)
        {
            string rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
            return str.Equals(rev, StringComparison.OrdinalIgnoreCase);
        }

        public void Demo()
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            if (IsPalindrome(str))
                Console.Write($"{str} is a palindrome");
            else
                Console.Write($"{str} is not a palindrome");
        }
    }
}
