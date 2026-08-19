using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google_Classroom.Week_4.Day_2._04_and_05_Submission_of_Linear_and_Binary_Search
{
    internal class Count_the_Occurrence_of_a_Word_in_a_File_Using_StreamReader
    {
        public static void Main(string[] args)
        {
            string path = "word_sample.txt";
            string targetWord = "c#";
            if (!File.Exists(path))
                File.WriteAllText(path, "C# is modern. C# is type-safe. Learn c# programming today.");
            int count = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(new char[] { ' ', '.', ',', ';', '!' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in parts)
                    {
                        if (word.Equals(targetWord, StringComparison.OrdinalIgnoreCase))
                            count++;
                    }
                }
            }
            Console.Write($"Count: {count}");
        }
    }
}
