using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._02_C__Methods_Level_1_Practice_Programs
{
    internal class Spring_Season_Check
    {
        public static bool IsSpringSeason(int month, int day)
        {
            if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
                return true;
            return false;
        }
        public void Demo()
        {
            Console.WriteLine("Enter month and day: ");
            int month = Convert.ToInt32(Console.ReadLine());
            int day = Convert.ToInt32(Console.ReadLine());
            bool isSpring = IsSpringSeason(month, day);
            if (isSpring)
                Console.Write("Its a Spring Season");
            else
                Console.Write("Not a Spring Season");
        }
    }
}
