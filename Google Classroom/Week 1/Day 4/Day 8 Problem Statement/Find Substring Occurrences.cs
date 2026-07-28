using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_4.Day_8_Problem_Statement
{
    internal class Find_Substring_Occurrences
    {
        public static int CountSubstringOccurrences(string str, string sub)
        {
            int count = 0;
            int index = 0;
            while ((index = str.IndexOf(sub, index)) != -1)
            {
                count++;
                index += sub.Length;
            }
            return count;
        }

        public void Demo()
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            Console.Write("Enter substring: ");
            string sub = Console.ReadLine();
            int count = CountSubstringOccurrences(str, sub);
            Console.Write($"Substring occurrences: {count}");
        }
    }
}
