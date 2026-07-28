using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_4.Day_8_Problem_Statement
{
    internal class Toggle_Case_of_Characters
    {
        public static string ToggleCase(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (char.IsUpper(ch))
                    result += char.ToLower(ch);
                else if (char.IsLower(ch))
                    result += char.ToUpper(ch);
                else
                    result += ch;
            }
            return result;
        }

        public void Demo()
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            string toggled = ToggleCase(str);
            Console.Write($"Toggled string: {toggled}");
        }
    }
}
