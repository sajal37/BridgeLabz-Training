using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._02_C__Methods_Level_1_Practice_Programs
{
    internal class Athlete_Triangular_Park_Rounds
    {
        public static double CalculateRounds(double side1, double side2, double side3)
        {
            double perimeter = side1 + side2 + side3;
            return 5000.0 / perimeter;
        }
        public void Demo()
        {
            Console.WriteLine("Enter 3 sides of triangular park in meters: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            double side2 = Convert.ToDouble(Console.ReadLine());
            double side3 = Convert.ToDouble(Console.ReadLine());
            double rounds = CalculateRounds(side1, side2, side3);
            Console.Write($"Rounds needed to complete 5km run: {rounds}");
        }
    }
}
