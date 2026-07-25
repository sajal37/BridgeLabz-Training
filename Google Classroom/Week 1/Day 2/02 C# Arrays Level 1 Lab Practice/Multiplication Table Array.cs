using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Arrays_Level_1_Lab_Practice
{
    internal class Multiplication_Table_Array
    {
        public void Demo()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int[] table = new int[10];
            for (int i = 1; i <= 10; i++)
            {
                table[i - 1] = number * i;
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {table[i - 1]}");
            }
        }
    }
}
