using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_4.Day_2._04_and_05_Submission_of_Linear_and_Binary_Search
{
    internal class Reverse_a_String_Using_StringBuilder
    {
        public static void Main(string[] args)
        {
            string str = "hello";
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
                sb.Append(str[i]);
            Console.WriteLine(sb.ToString());
        }
    }
}
