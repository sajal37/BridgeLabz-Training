using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Arrays_Level_1_Lab_Practice
{
    internal class Multiplication_Table_6_To_9_Array
    {
        public void Demo()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int[] multiplicationResult = new int[4];
            for (int i = 6; i <= 9; i++)
            {
                multiplicationResult[i - 6] = number * i;
            }
            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine($"{number} * {i} = {multiplicationResult[i - 6]}");
            }
        }
    }
}
