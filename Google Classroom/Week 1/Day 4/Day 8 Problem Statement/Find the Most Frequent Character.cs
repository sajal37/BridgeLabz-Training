using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_4.Day_8_Problem_Statement
{
    internal class Find_the_Most_Frequent_Character
    {
        public static char GetMostFrequentCharacter(string str)
        {
            int maxCount = 0;
            char mostFreq = str[0];
            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                        count++;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    mostFreq = str[i];
                }
            }
            return mostFreq;
        }

        public void Demo()
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            char result = GetMostFrequentCharacter(str);
            Console.Write($"Most Frequent Character: '{result}'");
        }
    }
}
