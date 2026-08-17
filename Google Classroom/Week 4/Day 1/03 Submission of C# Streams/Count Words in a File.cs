using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google_Classroom.Week_4.Day_1._03_Submission_of_C__Streams
{
    internal class Count_Words_in_a_File
    {
        public static void Main(string[] args)
        {
            string path = "article.txt";
            if (!File.Exists(path))
                File.WriteAllText(path, "c# streams are powerful streams help in file handling c# file handling streams in c# c# streams");
            Dictionary<string, int> map = new Dictionary<string, int>();
            using (StreamReader sr = new StreamReader(path))
            {
                string text = sr.ReadToEnd();
                string[] words = text.Split(new char[] { ' ', '\r', '\n', '\t', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string w in words)
                {
                    string word = w.ToLower();
                    if (map.ContainsKey(word))
                        map[word]++;
                    else
                        map[word] = 1;
                }
            }
            List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>(map);
            list.Sort((a, b) => b.Value.CompareTo(a.Value));
            int count = Math.Min(5, list.Count);
            for (int i = 0; i < count; i++)
                Console.WriteLine($"{list[i].Key}: {list[i].Value}");
        }
    }
}
