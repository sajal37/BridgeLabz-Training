using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Control_Flow_Level_1_Lab_Practice
{
    internal class Factorial_For
    {
        public void Demo()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int Fact = 1;
            for (int i = 1; i <= num; i++)
            {
                Fact *= i;
            }
            Console.Write($"Factorial: {Fact}");
        }
    }
}
