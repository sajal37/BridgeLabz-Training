using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Control_Flow_Level_1_Lab_Practice
{
    internal class Check_Smallest_Of_Three
    {
        public void Demo()
        {
            Console.WriteLine("Enter number1, number2, number3: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            bool Smallest = (num1 < num2) && (num1 < num3);
            Console.Write($"Is the first number the smallest? {Smallest}");
        }
    }
}
