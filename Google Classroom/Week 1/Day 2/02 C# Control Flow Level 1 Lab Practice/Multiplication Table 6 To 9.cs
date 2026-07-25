using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Control_Flow_Level_1_Lab_Practice
{
    internal class Multiplication_Table_6_To_9
    {
        public void Demo()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 6; i <= 9; i++)
            {
                int product = number * i;
                Console.WriteLine($"{number} * {i} = {product}");
            }
        }
    }
}
