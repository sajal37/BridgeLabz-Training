using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._02_C__Methods_Level_1_Practice_Programs
{
    internal class Smallest_And_Largest_Of_Three
    {
        public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
        {
            int smallest = Math.Min(number1, Math.Min(number2, number3));
            int largest = Math.Max(number1, Math.Max(number2, number3));
            return new int[] { smallest, largest };
        }
        public void Demo()
        {
            Console.WriteLine("Enter three numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int[] res = FindSmallestAndLargest(num1, num2, num3);
            Console.WriteLine($"Smallest: {res[0]}");
            Console.Write($"Largest: {res[1]}");
        }
    }
}
