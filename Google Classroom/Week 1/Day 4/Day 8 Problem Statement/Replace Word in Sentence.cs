using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_4.Day_8_Problem_Statement
{
    internal class Replace_Word_in_Sentence
    {
        public static string ReplaceWord(string sentence, string oldWord, string newWord)
        {
            return sentence.Replace(oldWord, newWord);
        }

        public void Demo()
        {
            Console.Write("Enter sentence: ");
            string sentence = Console.ReadLine();
            Console.Write("Enter word to replace: ");
            string oldWord = Console.ReadLine();
            Console.Write("Enter new word: ");
            string newWord = Console.ReadLine();
            string result = ReplaceWord(sentence, oldWord, newWord);
            Console.Write($"Modified Sentence: {result}");
        }
    }
}
