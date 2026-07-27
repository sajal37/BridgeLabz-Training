using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._03_C__Methods_Level_2_Practice_Programs
{
    internal class Unit_Converter_Extended
    {
        public static double ConvertYardsToFeet(double yards)
        {
            double yards2feet = 3;
            return yards * yards2feet;
        }
        public static double ConvertFeetToYards(double feet)
        {
            double feet2yards = 0.333333;
            return feet * feet2yards;
        }
        public static double ConvertMetersToInches(double meters)
        {
            double meters2inches = 39.3701;
            return meters * meters2inches;
        }
        public static double ConvertInchesToMeters(double inches)
        {
            double inches2meters = 0.0254;
            return inches * inches2meters;
        }
        public static double ConvertInchesToCm(double inches)
        {
            double inches2cm = 2.54;
            return inches * inches2cm;
        }
        public void Demo()
        {
            Console.Write("Enter yards: ");
            double yards = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{yards} yards = {ConvertYardsToFeet(yards)} feet");
            Console.Write("Enter feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{feet} feet = {ConvertFeetToYards(feet)} yards");
            Console.Write("Enter meters: ");
            double meters = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{meters} meters = {ConvertMetersToInches(meters)} inches");
            Console.Write("Enter inches: ");
            double inches = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{inches} inches = {ConvertInchesToMeters(inches)} meters");
            Console.Write($"{inches} inches = {ConvertInchesToCm(inches)} cm");
        }
    }
}
