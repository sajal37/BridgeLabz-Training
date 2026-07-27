using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._03_C__Methods_Level_2_Practice_Programs
{
    internal class Random_Array_Min_Max_Average
    {
        public static int[] Generate4DigitRandomArray(int size)
        {
            Random random = new Random();
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(1000, 10000);
            }
            return numbers;
        }
        public static double[] FindAverageMinMax(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                min = Math.Min(min, numbers[i]);
                max = Math.Max(max, numbers[i]);
                sum += numbers[i];
            }
            double avg = sum / numbers.Length;
            return new double[] { avg, min, max };
        }
        public void Demo()
        {
            int[] numbers = Generate4DigitRandomArray(5);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            double[] stats = FindAverageMinMax(numbers);
            Console.WriteLine($"Average: {stats[0]}");
            Console.WriteLine($"Min: {stats[1]}");
            Console.Write($"Max: {stats[2]}");
        }
    }
}
