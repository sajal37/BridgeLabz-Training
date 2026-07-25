using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Control_Flow_Level_1_Lab_Practice
{
    internal class Check_Positive_Negative_Zero
    {
        public void Demo()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
                Console.Write("positive");
            else if (number < 0)
                Console.Write("negative");
            else
                Console.Write("zero");
        }
    }
}
