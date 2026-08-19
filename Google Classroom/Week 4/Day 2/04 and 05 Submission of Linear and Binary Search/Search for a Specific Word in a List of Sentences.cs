using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_4.Day_2._04_and_05_Submission_of_Linear_and_Binary_Search
{
    internal class Search_for_a_Specific_Word_in_a_List_of_Sentences
    {
        public static void Main(string[] args)
        {
            string[] sentences = {
                "Today is a bright sunny day",
                "Linear search is very simple to implement",
                "Data structures and algorithms in C#",
                "Practice programming every single day"
            };
            string target = "algorithms";
            for (int i = 0; i < sentences.Length; i++)
            {
                if (sentences[i].IndexOf(target, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.Write($"Index {i}: {sentences[i]}");
                    break;
                }
            }
        }
    }
}
