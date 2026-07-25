using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._03_C__Control_Flow_Level_2_Lab_Practice
{
    internal class Multiples_Below_100
    {
        public void Demo()
        {
            Console.WriteLine("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 100; i >= 1; i--)
            {
                if (i % number == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
