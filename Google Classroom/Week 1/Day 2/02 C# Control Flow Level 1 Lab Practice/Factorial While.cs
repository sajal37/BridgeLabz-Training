using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Control_Flow_Level_1_Lab_Practice
{
    internal class Factorial_While
    {
        public void Demo()
        {
            Console.WriteLine("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int Fact = 1;
            int i = 1;
            while (i <= num)
            {
                Fact *= i;
                i++;
            }
            Console.Write($"Factorial: {Fact}");
        }
    }
}
