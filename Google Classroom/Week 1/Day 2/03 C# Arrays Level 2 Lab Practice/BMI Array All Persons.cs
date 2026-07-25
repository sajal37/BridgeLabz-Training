using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._03_C__Arrays_Level_2_Lab_Practice
{
    internal class BMI_Array_All_Persons
    {
        public void Demo()
        {
            Console.WriteLine("Enter number of persons: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] weights = new double[n];
            double[] heights = new double[n];
            double[] bmis = new double[n];
            string[] statuses = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter weight (kg) and height (cm) for person {i + 1}: ");
                weights[i] = Convert.ToDouble(Console.ReadLine());
                heights[i] = Convert.ToDouble(Console.ReadLine());
                double heightMeter = heights[i] / 100.0;
                bmis[i] = weights[i] / (heightMeter * heightMeter);
                if (bmis[i] <= 18.4)
                    statuses[i] = "Underweight";
                else if (bmis[i] <= 24.9)
                    statuses[i] = "Normal";
                else if (bmis[i] <= 39.9)
                    statuses[i] = "Overweight";
                else
                    statuses[i] = "Obese";
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Person {i + 1} - Height: {heights[i]}cm, Weight: {weights[i]}kg, BMI: {bmis[i]}, Status: {statuses[i]}");
            }
        }
    }
}
