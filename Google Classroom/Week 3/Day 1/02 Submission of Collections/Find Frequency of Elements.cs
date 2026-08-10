using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_1._02_Submission_of_Collections
{
    internal class Find_Frequency_of_Elements
    {
        public void Demo()
        {
            List<string> items = new List<string> { "apple", "banana", "apple", "orange" };
            Dictionary<string, int> FreqDict = new Dictionary<string, int>();

            foreach (string item in items)
            {
                if (FreqDict.ContainsKey(item))
                {
                    FreqDict[item]++;
                }
                else
                {
                    FreqDict[item] = 1;
                }
            }

            Console.WriteLine("Element Frequencies:");
            foreach (KeyValuePair<string, int> entry in FreqDict)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}
