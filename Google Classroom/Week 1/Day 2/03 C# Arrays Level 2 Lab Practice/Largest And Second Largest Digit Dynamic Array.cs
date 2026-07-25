using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._03_C__Arrays_Level_2_Lab_Practice
{
    internal class Largest_And_Second_Largest_Digit_Dynamic_Array
    {
        public void Demo()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int maxDigit = 10;
            int[] digits = new int[maxDigit];
            int index = 0;
            int temp = number;
            while (temp != 0)
            {
                if (index == maxDigit)
                {
                    maxDigit += 10;
                    int[] tempArray = new int[maxDigit];
                    for (int i = 0; i < digits.Length; i++)
                    {
                        tempArray[i] = digits[i];
                    }
                    digits = tempArray;
                }
                int remainder = temp % 10;
                digits[index] = remainder;
                index++;
                temp /= 10;
            }
            int largest = 0;
            int secondLargest = 0;
            for (int i = 0; i < index; i++)
            {
                if (digits[i] > largest)
                {
                    secondLargest = largest;
                    largest = digits[i];
                }
                else if (digits[i] > secondLargest && digits[i] != largest)
                {
                    secondLargest = digits[i];
                }
            }
            Console.WriteLine($"Largest Digit: {largest}");
            Console.Write($"Second Largest Digit: {secondLargest}");
        }
    }
}
