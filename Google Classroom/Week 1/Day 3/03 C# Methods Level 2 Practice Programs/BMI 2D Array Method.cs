using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._03_C__Methods_Level_2_Practice_Programs
{
    internal class BMI_2D_Array_Method
    {
        public static void CalculateBMI(double[,] data)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                double weight = data[i, 0];
                double heightCm = data[i, 1];
                double heightM = heightCm / 100.0;
                data[i, 2] = weight / (heightM * heightM);
            }
        }
        public static string[] GetBMIStatus(double[,] data)
        {
            int n = data.GetLength(0);
            string[] statuses = new string[n];
            for (int i = 0; i < n; i++)
            {
                double bmi = data[i, 2];
                if (bmi <= 18.4)
                    statuses[i] = "Underweight";
                else if (bmi <= 24.9)
                    statuses[i] = "Normal";
                else if (bmi <= 39.9)
                    statuses[i] = "Overweight";
                else
                    statuses[i] = "Obese";
            }
            return statuses;
        }
        public void Demo()
        {
            double[,] personData = new double[10, 3];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter weight (kg) and height (cm) for person {i + 1}: ");
                personData[i, 0] = Convert.ToDouble(Console.ReadLine());
                personData[i, 1] = Convert.ToDouble(Console.ReadLine());
            }
            CalculateBMI(personData);
            string[] statuses = GetBMIStatus(personData);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Person {i + 1}: {personData[i, 0]}kg, {personData[i, 1]}cm, BMI: {personData[i, 2]:F2}, {statuses[i]}");
            }
        }
    }
}
