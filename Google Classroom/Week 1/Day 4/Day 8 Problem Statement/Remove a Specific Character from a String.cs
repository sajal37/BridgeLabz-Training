using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_4.Day_8_Problem_Statement
{
    internal class Remove_a_Specific_Character_from_a_String
    {
        public static string RemoveCharacter(string str, char ch)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ch)
                    result += str[i];
            }
            return result;
        }

        public void Demo()
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            Console.Write("Enter character to remove: ");
            char ch = Console.ReadLine()[0];
            string result = RemoveCharacter(str, ch);
            Console.Write($"Modified String: \"{result}\"");
        }
    }
}
