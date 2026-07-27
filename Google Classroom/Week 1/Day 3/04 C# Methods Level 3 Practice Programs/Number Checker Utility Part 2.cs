using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._04_C__Methods_Level_3_Practice_Programs
{
    internal class Number_Checker_Utility_Part_2
    {
        public static int CountDigits(int number)
        {
            int temp = Math.Abs(number);
            if (temp == 0)
                return 1;
            int count = 0;
            while (temp != 0)
            {
                count++;
                temp /= 10;
            }
            return count;
        }
        public static int[] GetDigits(int number)
        {
            int count = CountDigits(number);
            int[] digits = new int[count];
            int temp = Math.Abs(number);
            for (int i = count - 1; i >= 0; i--)
            {
                digits[i] = temp % 10;
                temp /= 10;
            }
            return digits;
        }
        public static int FindSumOfDigits(int[] digits)
        {
            int sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sum += digits[i];
            }
            return sum;
        }
        public static double FindSumOfSquaresOfDigits(int[] digits)
        {
            double sumSq = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sumSq += Math.Pow(digits[i], 2);
            }
            return sumSq;
        }
        public static bool IsHarshadNumber(int number, int[] digits)
        {
            int sum = FindSumOfDigits(digits);
            if (sum == 0)
                return false;
            return number % sum == 0;
        }
        public static int[,] FindDigitFrequency(int[] digits)
        {
            int[] counts = new int[10];
            for (int i = 0; i < digits.Length; i++)
            {
                counts[digits[i]]++;
            }
            int uniqueCount = 0;
            for (int i = 0; i < 10; i++)
            {
                if (counts[i] > 0)
                    uniqueCount++;
            }
            int[,] freq = new int[uniqueCount, 2];
            int index = 0;
            for (int i = 0; i < 10; i++)
            {
                if (counts[i] > 0)
                {
                    freq[index, 0] = i;
                    freq[index, 1] = counts[i];
                    index++;
                }
            }
            return freq;
        }
        public void Demo()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] digits = GetDigits(number);
            int sum = FindSumOfDigits(digits);
            double sumSq = FindSumOfSquaresOfDigits(digits);
            bool harshad = IsHarshadNumber(number, digits);
            int[,] freq = FindDigitFrequency(digits);
            Console.WriteLine($"Sum of digits: {sum}");
            Console.WriteLine($"Sum of squares: {sumSq}");
            Console.WriteLine($"Harshad: {harshad}");
            for (int i = 0; i < freq.GetLength(0); i++)
            {
                Console.WriteLine($"Digit {freq[i, 0]}: {freq[i, 1]}");
            }
        }
    }
}
