using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._03_C__Arrays_Level_2_Lab_Practice
{
    internal class Digit_Frequency_Array
    {
        public void Demo()
        {
            long number = Convert.ToInt64(Console.ReadLine());
            long temp = Math.Abs(number);
            int count = 0;
            long t = temp;
            while (t != 0)
            {
                count++;
                t /= 10;
            }
            int[] digits = new int[count];
            t = temp;
            for (int i = 0; i < count; i++)
            {
                digits[i] = (int)(t % 10);
                t /= 10;
            }
            int[] frequency = new int[10];
            for (int i = 0; i < count; i++)
            {
                frequency[digits[i]]++;
            }
            for (int i = 0; i < 10; i++)
            {
                if (frequency[i] > 0)
                    Console.WriteLine($"Digit {i}: {frequency[i]} time(s)");
            }
        }
    }
}
