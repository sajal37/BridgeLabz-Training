using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._04_C__Methods_Level_3_Practice_Programs
{
    internal class Football_Team_Heights
    {
        public static int[] GenerateHeights(int size)
        {
            Random rand = new Random();
            int[] heights = new int[size];
            for (int i = 0; i < size; i++)
            {
                heights[i] = rand.Next(150, 251);
            }
            return heights;
        }
        public static int FindSum(int[] heights)
        {
            int sum = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                sum += heights[i];
            }
            return sum;
        }
        public static double FindMean(int[] heights)
        {
            int sum = FindSum(heights);
            return (double)sum / heights.Length;
        }
        public static int FindShortest(int[] heights)
        {
            int min = heights[0];
            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] < min)
                    min = heights[i];
            }
            return min;
        }
        public static int FindTallest(int[] heights)
        {
            int max = heights[0];
            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > max)
                    max = heights[i];
            }
            return max;
        }
        public void Demo()
        {
            int[] heights = GenerateHeights(11);
            for (int i = 0; i < heights.Length; i++)
            {
                Console.WriteLine($"Player {i + 1}: {heights[i]} cm");
            }
            int sum = FindSum(heights);
            double mean = FindMean(heights);
            int shortest = FindShortest(heights);
            int tallest = FindTallest(heights);
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Mean: {mean}");
            Console.WriteLine($"Shortest: {shortest}");
            Console.Write($"Tallest: {tallest}");
        }
    }
}
