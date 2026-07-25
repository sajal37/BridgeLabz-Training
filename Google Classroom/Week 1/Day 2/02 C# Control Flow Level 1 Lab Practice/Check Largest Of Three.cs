using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Control_Flow_Level_1_Lab_Practice
{
    internal class Check_Largest_Of_Three
    {
        public void Demo()
        {
            Console.Write("Enter 3 numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Is the first number the largest? {(num1 > num2) && (num1 > num3)}");
            Console.WriteLine($"Is the second number the largest? {(num2 > num1) && (num2 > num3)}");
            Console.Write($"Is the third number the largest? {(num3 > num1) && (num3 > num2)}");
        }
    }
}
