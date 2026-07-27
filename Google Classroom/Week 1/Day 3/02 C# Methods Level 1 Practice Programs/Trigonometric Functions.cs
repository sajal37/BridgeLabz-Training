using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._02_C__Methods_Level_1_Practice_Programs
{
    internal class Trigonometric_Functions
    {
        public static double[] CalculateTrigonometricFunctions(double angle)
        {
            double radians = angle * Math.PI / 180.0;
            double sine = Math.Sin(radians);
            double cosine = Math.Cos(radians);
            double tangent = Math.Tan(radians);
            return new double[] { sine, cosine, tangent };
        }
        public void Demo()
        {
            Console.Write("Enter angle in degrees: ");
            double angle = Convert.ToDouble(Console.ReadLine());
            double[] res = CalculateTrigonometricFunctions(angle);
            Console.WriteLine($"Sine: {res[0]}");
            Console.WriteLine($"Cosine: {res[1]}");
            Console.Write($"Tangent: {res[2]}");
        }
    }
}
