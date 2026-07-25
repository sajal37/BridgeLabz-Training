using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Control_Flow_Level_1_Lab_Practice
{
    internal class Odd_Even_Numbers
    {
        public void Demo()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"{i} is Even");
                else
                    Console.WriteLine($"{i} is Odd");
            }
        }
    }
}
