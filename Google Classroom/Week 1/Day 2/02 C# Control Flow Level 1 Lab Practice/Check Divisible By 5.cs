using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Control_Flow_Level_1_Lab_Practice
{
    internal class Check_Divisible_By_5
    {
        public void Demo()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            bool Divisible = num % 5 == 0;
            Console.Write($"Is the number {num} divisible by 5? {Divisible}");
        }
    }
}
