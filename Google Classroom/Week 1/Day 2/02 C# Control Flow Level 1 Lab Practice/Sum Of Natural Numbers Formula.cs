using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Control_Flow_Level_1_Lab_Practice
{
    internal class Sum_Of_Natural_Numbers_Formula
    {
        public void Demo()
        {
            Console.WriteLine("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                int Sum= number * (number + 1) / 2;
                Console.Write($"The sum of {number} natural numbers is {Sum}");
            }
            else
                Console.Write($"The number {number} is not a natural number");
        }
    }
}
