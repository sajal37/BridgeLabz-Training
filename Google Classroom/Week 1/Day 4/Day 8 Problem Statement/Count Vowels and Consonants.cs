using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_4.Day_8_Problem_Statement
{
    internal class Count_Vowels_and_Consonants
    {
        public static int[] CountVowelsAndConsonants(string str)
        {
            int vowels = 0;
            int consonants = 0;
            str = str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch >= 'a' && ch <= 'z')
                {
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                        vowels++;
                    else
                        consonants++;
                }
            }
            return new int[] { vowels, consonants };
        }

        public void Demo()
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            int[] result = CountVowelsAndConsonants(str);
            Console.WriteLine($"Vowels: {result[0]}");
            Console.Write($"Consonants: {result[1]}");
        }
    }
}
