using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._03_C__Arrays_Level_2_Lab_Practice
{
    internal class BMI_2D_Array_All_Persons
    {
        public void Demo()
        {
            Console.WriteLine("Enter number of persons: ");
            int number = Convert.ToInt32(Console.ReadLine());
            double[,] personData = new double[number, 3];
            string[] weightStatus = new string[number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Enter weight (kg) and height (cm) for person {i + 1}: ");
                double w = Convert.ToDouble(Console.ReadLine());
                double h = Convert.ToDouble(Console.ReadLine());
                if (w <= 0 || h <= 0)
                {
                    i--;
                    continue;
                }
                personData[i, 0] = w;
                personData[i, 1] = h;
                double hMeter = h / 100.0;
                personData[i, 2] = w / (hMeter * hMeter);
                double bmi = personData[i, 2];
                if (bmi <= 18.4)
                    weightStatus[i] = "Underweight";
                else if (bmi <= 24.9)
                    weightStatus[i] = "Normal";
                else if (bmi <= 39.9)
                    weightStatus[i] = "Overweight";
                else
                    weightStatus[i] = "Obese";
            }
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Person {i + 1} - Weight: {personData[i, 0]}kg, Height: {personData[i, 1]}cm, BMI: {personData[i, 2]}, Status: {weightStatus[i]}");
            }
        }
    }
}
