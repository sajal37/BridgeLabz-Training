using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._03_C__Control_Flow_Level_2_Lab_Practice
{
    internal class Power_Of_Number
    {
        public void Demo()
        {
            Console.Write("Enter number and power: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int power = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }
            Console.Write($"Result: {result}");
        }
    }
}
