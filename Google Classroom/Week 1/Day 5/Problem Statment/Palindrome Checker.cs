using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_5.Problem_Statment
{
    internal class Palindrome_Checker
    {
        public static bool CheckPalindrome(string str)
        {
            string reversed = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }
            return str == reversed;
        }
        public static void DisplayResult(string str, bool isPalindrome)
        {
            if (isPalindrome)
                Console.Write($"{str} is a palindrome.");
            else
                Console.Write($"{str} is not a palindrome.");
        }
        public void Demo()
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            bool result = CheckPalindrome(str);
            DisplayResult(str, result);
        }
    }
}
