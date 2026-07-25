using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._03_C__Control_Flow_Level_2_Lab_Practice
{
    internal class BMI_Calculation
    {
        public void Demo()
        {
            double weight = Convert.ToDouble(Console.ReadLine());
            double heightCm = Convert.ToDouble(Console.ReadLine());
            double heightMeter = heightCm / 100.0;
            double BMI = weight / (heightMeter * heightMeter);
            string status;
            if (BMI <= 18.4)
                status = "Underweight";
            else if (BMI <= 24.9)
                status = "Normal";
            else if (BMI <= 39.9)
                status = "Overweight";
            else
                status = "Obese";
            Console.WriteLine($"BMI: {BMI}");
            Console.Write($"Status: {status}");
        }
    }
}
