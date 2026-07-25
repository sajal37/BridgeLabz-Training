using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._03_C__Arrays_Level_2_Lab_Practice
{
    internal class Youngest_And_Tallest_Friends_Array
    {
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
            int youngestIndex = 0;
            int tallestIndex = 0;
            for (int i = 1; i < 3; i++)
            {
                if (ages[i] < ages[youngestIndex])
                    youngestIndex = i;
                if (heights[i] > heights[tallestIndex])
                    tallestIndex = i;
            }
            Console.WriteLine($"Youngest Friend: {names[youngestIndex]} (Age: {ages[youngestIndex]})");
            Console.Write($"Tallest Friend: {names[tallestIndex]} (Height: {heights[tallestIndex]})");
        }
    }
}
