using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Control_Flow_Level_1_Lab_Practice
{
    internal class Spring_Season
    {
        public void Demo()
        {
            Console.WriteLine("Enter month and day: ");
            int month = Convert.ToInt32(Console.ReadLine());
            int day = Convert.ToInt32(Console.ReadLine());
            if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
                Console.Write("Its a Spring Season");
            else
                Console.Write("Not a Spring Season");
        }
    }
}
