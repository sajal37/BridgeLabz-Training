using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_4.Day_8_Problem_Statement
{
    internal class Find_the_Longest_Word_in_a_Sentence
    {
        public static string FindLongestWord(string sentence)
        {
            string[] words = sentence.Split(' ');
            string longest = words[0];
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > longest.Length)
                    longest = words[i];
            }
            return longest;
        }

        public void Demo()
        {
            Console.Write("Enter sentence: ");
            string sentence = Console.ReadLine();
            string longest = FindLongestWord(sentence);
            Console.Write($"Longest word: {longest}");
        }
    }
}
