using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Arrays_Level_1_Lab_Practice
{
    internal class Mean_Height_Football_Team
    {
        public void Demo()
        {
            double[] heights = new double[11];
            double sum = 0.0;
            for (int i = 0; i < heights.Length; i++)
            {
                heights[i] = Convert.ToDouble(Console.ReadLine());
                sum += heights[i];
            }
            double mean = sum / 11.0;
            Console.Write($"Mean height of the football team: {mean}");
        }
    }
}
