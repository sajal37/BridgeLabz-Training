using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._02_C__Methods_Level_1_Practice_Programs
{
    internal class Sum_Of_Natural_Numbers_Method
    {
        public static int FindSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
        public void Demo()
        {
            Console.Write("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = FindSum(n);
            Console.Write($"Sum of {n} natural numbers is {sum}");
        }
    }
}
