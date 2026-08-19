using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Google_Classroom.Week_4.Day_2._04_and_05_Submission_of_Linear_and_Binary_Search
{
    internal class Concatenate_Strings_Efficiently_Using_StringBuilder
    {
        public static void Main(string[] args)
        {
            string[] words = { "BridgeLabz", "Solutions", "Fast", "Track", "Training" };
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                sb.Append(words[i]);
                if (i < words.Length - 1) sb.Append(" ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
