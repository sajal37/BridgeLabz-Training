using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._04_C__Methods_Level_3_Practice_Programs
{
    internal class Number_Checker_Utility_Part_1
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
        public static bool IsDuckNumber(int[] digits)
        {
            if (digits.Length == 0 || digits[0] == 0)
                return false;
            for (int i = 1; i < digits.Length; i++)
            {
                if (digits[i] == 0)
                    return true;
            }
            return false;
        }
        public static bool IsArmstrongNumber(int[] digits, int originalNumber)
        {
            int power = digits.Length;
            double sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sum += Math.Pow(digits[i], power);
            }
            return (int)sum == originalNumber;
        }
        public static int[] FindLargestAndSecondLargest(int[] digits)
        {
            int largest = Int32.MinValue;
            int secondLargest = Int32.MinValue;
            for (int i = 0; i < digits.Length; i++)
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
            return new int[] { largest, secondLargest };
        }
        public static int[] FindSmallestAndSecondSmallest(int[] digits)
        {
            int smallest = Int32.MaxValue;
            int secondSmallest = Int32.MaxValue;
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = digits[i];
                }
                else if (digits[i] < secondSmallest && digits[i] != smallest)
                {
                    secondSmallest = digits[i];
                }
            }
            return new int[] { smallest, secondSmallest };
        }
        public void Demo()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = CountDigits(number);
            int[] digits = GetDigits(number);
            bool duck = IsDuckNumber(digits);
            bool armstrong = IsArmstrongNumber(digits, number);
            int[] maxes = FindLargestAndSecondLargest(digits);
            int[] mins = FindSmallestAndSecondSmallest(digits);
            Console.WriteLine($"Digit Count: {count}");
            Console.WriteLine($"Duck Number: {duck}");
            Console.WriteLine($"Armstrong: {armstrong}");
            Console.WriteLine($"Largest: {maxes[0]}, 2nd Largest: {maxes[1]}");
            Console.Write($"Smallest: {mins[0]}, 2nd Smallest: {mins[1]}");
        }
    }
}
