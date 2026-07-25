using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Arrays_Level_1_Lab_Practice
{
    internal class Number_Analysis_Array
    {
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
                if (numbers[i] > 0)
                {
                    if (numbers[i] % 2 == 0)
                        Console.WriteLine($"{numbers[i]} is positive and even");
                    else
                        Console.WriteLine($"{numbers[i]} is positive and odd");
                }
                else if (numbers[i] < 0)
                    Console.WriteLine($"{numbers[i]} is negative");
                else
                    Console.WriteLine("zero");
            }
            int first = numbers[0];
            int last = numbers[numbers.Length - 1];
            if (first == last)
                Console.Write("First and last elements are equal.");
            else if (first > last)
                Console.Write("First element is greater than last element.");
            else
                Console.Write("First element is less than last element.");
        }
    }
}
