using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._02_C__Methods_Level_1_Practice_Programs
{
    internal class Check_Number_Sign
    {
        public static int CheckSign(int number)
        {
            if (number < 0) return -1;
            if (number > 0) return 1;
            return 0;
        }
        public void Demo()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = CheckSign(number);
            if (result == 1)
                Console.Write("Positive");
            else if (result == -1)
                Console.Write("Negative");
            else
                Console.Write("Zero");
        }
    }
}
