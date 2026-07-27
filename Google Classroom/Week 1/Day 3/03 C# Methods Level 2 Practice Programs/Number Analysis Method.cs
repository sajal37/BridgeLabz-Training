using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._03_C__Methods_Level_2_Practice_Programs
{
    internal class Number_Analysis_Method
    {
        public static bool IsPositive(int number)
        {
            return number >= 0;
        }
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public static int Compare(int number1, int number2)
        {
            if (number1 > number2)
                return 1;
            if (number1 == number2)
                return 0;
            return -1;
        }
        public void Demo()
        {
            int[] numbers = new int[5];
            Console.WriteLine("Enter 5 numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsPositive(numbers[i]))
                {
                    if (IsEven(numbers[i]))
                        Console.WriteLine($"{numbers[i]} is positive and even");
                    else
                        Console.WriteLine($"{numbers[i]} is positive and odd");
                }
                else
                {
                    Console.WriteLine($"{numbers[i]} is negative");
                }
            }
            int comp = Compare(numbers[0], numbers[numbers.Length - 1]);
            if (comp == 0)
                Console.Write("First and last are equal.");
            else if (comp == 1)
                Console.Write("First is greater than last.");
            else
                Console.Write("First is less than last.");
        }
    }
}
