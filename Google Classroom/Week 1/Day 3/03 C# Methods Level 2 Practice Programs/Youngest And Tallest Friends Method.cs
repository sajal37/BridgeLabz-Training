using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._03_C__Methods_Level_2_Practice_Programs
{
    internal class Youngest_And_Tallest_Friends_Method
    {
        public static string FindYoungest(string[] names, int[] ages)
        {
            int minIndex = 0;
            for (int i = 1; i < ages.Length; i++)
            {
                if (ages[i] < ages[minIndex])
                    minIndex = i;
            }
            return names[minIndex];
        }
        public static string FindTallest(string[] names, double[] heights)
        {
            int maxIndex = 0;
            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > heights[maxIndex])
                    maxIndex = i;
            }
            return names[maxIndex];
        }
        public void Demo()
        {
            string[] names = { "Amar", "Akbar", "Anthony" };
            int[] ages = new int[3];
            double[] heights = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter age and height for {names[i]}: ");
                ages[i] = Convert.ToInt32(Console.ReadLine());
                heights[i] = Convert.ToDouble(Console.ReadLine());
            }
            string youngest = FindYoungest(names, ages);
            string tallest = FindTallest(names, heights);
            Console.WriteLine($"Youngest friend: {youngest}");
            Console.Write($"Tallest friend: {tallest}");
        }
    }
}
