using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_4.Day_2._04_and_05_Submission_of_Linear_and_Binary_Search
{
    internal class Remove_Duplicates_from_a_String_Using_StringBuilder
    {
        public static void Main(string[] args)
        {
            string str = "programming";
            StringBuilder sb = new StringBuilder();
            HashSet<char> set1 = new HashSet<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (!set1.Contains(str[i]))
                {
                    set1.Add(str[i]);
                    sb.Append(str[i]);
                }
            }
            Console.Write(sb.ToString());
        }
    }
}
