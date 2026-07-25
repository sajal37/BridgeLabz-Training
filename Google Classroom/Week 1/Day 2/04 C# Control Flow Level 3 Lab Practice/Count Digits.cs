using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._04_C__Control_Flow_Level_3_Lab_Practice
{
    internal class Count_Digits
    {
        public void Demo()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int temp = number;
            int count = 0;
            while (temp != 0)
            {
                temp /= 10;
                count++;
            }
            Console.Write($"Number of digits in {number} is {count}");
        }
    }
}
