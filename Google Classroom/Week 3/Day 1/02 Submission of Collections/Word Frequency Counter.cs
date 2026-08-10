using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_1._02_Submission_of_Collections
{
    internal class Word_Frequency_Counter
    {
        public void Demo()
        {
            string text = "Hello world, hello Java!";
            char[] delimiters = new char[] { ' ', ',', '!', '.', '?' };
            string[] words = text.ToLower().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> WordCounts = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (WordCounts.ContainsKey(word))
                {
                    WordCounts[word]++;
                }
                else
                {
                    WordCounts[word] = 1;
                }
            }

            Console.WriteLine("Word Frequency:");
            foreach (KeyValuePair<string, int> pair in WordCounts)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
