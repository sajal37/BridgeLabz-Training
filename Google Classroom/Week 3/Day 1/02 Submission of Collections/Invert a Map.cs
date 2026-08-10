using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_1._02_Submission_of_Collections
{
    internal class Invert_a_Map
    {
        public void Demo()
        {
            Dictionary<string, int> map = new Dictionary<string, int>
            {
                { "A", 1 },
                { "B", 2 },
                { "C", 1 }
            };

            Dictionary<int, List<string>> invertedMap = new Dictionary<int, List<string>>();

            foreach (KeyValuePair<string, int> pair in map)
            {
                int val = pair.Value;
                string key = pair.Key;

                if (!invertedMap.ContainsKey(val))
                {
                    invertedMap[val] = new List<string>();
                }
                invertedMap[val].Add(key);
            }

            Console.WriteLine("Inverted Map:");
            foreach (KeyValuePair<int, List<string>> entry in invertedMap)
            {
                Console.Write($"{entry.Key} = [");
                for (int i = 0; i < entry.Value.Count; i++)
                {
                    Console.Write(entry.Value[i]);
                    if (i < entry.Value.Count - 1)
                        Console.Write(", ");
                }
                Console.WriteLine("]");
            }
        }
    }
}
