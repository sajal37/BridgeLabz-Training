using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._03_C__Methods_Level_2_Practice_Programs
{
    internal class Quadratic_Roots
    {
        public static double[] FindRoots(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta > 0)
            {
                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return new double[] { root1, root2 };
            }
            if (delta == 0)
            {
                double root = -b / (2 * a);
                return new double[] { root };
            }
            return new double[0];
        }
        public void Demo()
        {
            Console.WriteLine("Enter a, b, c: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double[] roots = FindRoots(a, b, c);
            if (roots.Length == 2)
            {
                Console.WriteLine($"Root 1: {roots[0]}");
                Console.Write($"Root 2: {roots[1]}");
            }
            else if (roots.Length == 1)
            {
                Console.Write($"Single Root: {roots[0]}");
            }
            else
            {
                Console.Write("No real roots.");
            }
        }
    }
}
