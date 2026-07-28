using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_4.Day_8_Problem_Statement
{
    internal class Compare_Two_Strings
    {
        public static int CompareLexicographically(string str1, string str2)
        {
            int minLen = Math.Min(str1.Length, str2.Length);
            for (int i = 0; i < minLen; i++)
            {
                if (str1[i] != str2[i])
                    return str1[i] - str2[i];
            }
            return str1.Length - str2.Length;
        }

        public void Demo()
        {
            Console.Write("Enter String 1: ");
            string str1 = Console.ReadLine();
            Console.Write("Enter String 2: ");
            string str2 = Console.ReadLine();
            int result = CompareLexicographically(str1, str2);
            if (result < 0)
                Console.Write($"\"{str1}\" comes before \"{str2}\" in lexicographical order");
            else if (result > 0)
                Console.Write($"\"{str2}\" comes before \"{str1}\" in lexicographical order");
            else
                Console.Write($"\"{str1}\" and \"{str2}\" are equal");
        }
    }
}
