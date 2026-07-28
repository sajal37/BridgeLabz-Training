using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_4.Day_8_Problem_Statement
{
    internal class Remove_Duplicates_from_a_String
    {
        public static string RemoveDuplicates(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                    result += str[i];
            }
            return result;
        }

        public void Demo()
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            string result = RemoveDuplicates(str);
            Console.Write($"Modified string: {result}");
        }
    }
}
