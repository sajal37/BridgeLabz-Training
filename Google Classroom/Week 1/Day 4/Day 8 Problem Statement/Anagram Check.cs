using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_4.Day_8_Problem_Statement
{
    internal class Anagram_Check
    {
        public static bool CheckAnagrams(string str1, string str2)
        {
            str1 = str1.Replace(" ", "").ToLower();
            str2 = str2.Replace(" ", "").ToLower();
            if (str1.Length != str2.Length)
                return false;
            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            string sorted1 = new string(arr1);
            string sorted2 = new string(arr2);
            return sorted1.Equals(sorted2);
        }

        public void Demo()
        {
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();
            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();
            if (CheckAnagrams(str1, str2))
                Console.Write("The strings are anagrams.");
            else
                Console.Write("The strings are not anagrams.");
        }
    }
}
