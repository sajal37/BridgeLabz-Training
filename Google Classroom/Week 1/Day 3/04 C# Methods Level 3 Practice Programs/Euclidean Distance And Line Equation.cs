using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._04_C__Methods_Level_3_Practice_Programs
{
    internal class Euclidean_Distance_And_Line_Equation
    {
        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        public static double[] CalculateLineEquation(double x1, double y1, double x2, double y2)
        {
            double slope = (y2 - y1) / (x2 - x1);
            double intercept = y1 - slope * x1;
            return new double[] { slope, intercept };
        }
        public void Demo()
        {
            Console.WriteLine("Enter x1 and y1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2 and y2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double distance = CalculateDistance(x1, y1, x2, y2);
            double[] line = CalculateLineEquation(x1, y1, x2, y2);
            Console.WriteLine($"Distance: {distance}");
            Console.Write($"y = {line[0]}*x + {line[1]}");
        }
    }
}
