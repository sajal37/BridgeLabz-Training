using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._03_C__Arrays_Level_2_Lab_Practice
{
    internal class Reverse_Number_Array
    {
        public void Demo()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int temp = number;
            int count = 0;
            while (temp != 0)
            {
                count++;
                temp /= 10;
            }
            int[] digits = new int[count];
            temp = number;
            for (int i = 0; i < count; i++)
            {
                digits[i] = temp % 10;
                temp /= 10;
            }
            int[] reversed = new int[count];
            for (int i = 0; i < count; i++)
            {
                reversed[i] = digits[i];
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write(reversed[i] + " ");
            }
        }
    }
}
