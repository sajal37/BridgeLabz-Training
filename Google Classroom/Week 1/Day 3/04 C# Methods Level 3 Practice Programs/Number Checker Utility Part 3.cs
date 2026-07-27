using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._04_C__Methods_Level_3_Practice_Programs
{
    internal class Number_Checker_Utility_Part_3
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
        public static int[] ReverseDigits(int[] digits)
        {
            int[] reversed = new int[digits.Length];
            for (int i = 0; i < digits.Length; i++)
            {
                reversed[i] = digits[digits.Length - 1 - i];
            }
            return reversed;
        }
        public static bool CompareArrays(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
                return false;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }
            return true;
        }
        public static bool IsPalindrome(int number, int[] digits)
        {
            int[] reversed = ReverseDigits(digits);
            return CompareArrays(digits, reversed);
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
        public void Demo()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] digits = GetDigits(number);
            bool palindrome = IsPalindrome(number, digits);
            bool duck = IsDuckNumber(digits);
            Console.WriteLine($"Palindrome: {palindrome}");
            Console.Write($"Duck Number: {duck}");
        }
    }
}
