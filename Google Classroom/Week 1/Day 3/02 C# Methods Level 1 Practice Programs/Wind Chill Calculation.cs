using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._02_C__Methods_Level_1_Practice_Programs
{
    internal class Wind_Chill_Calculation
    {
        public static double CalculateWindChill(double temperature, double windSpeed)
        {
            return 35.74 + (0.6215 * temperature) + ((0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16));
        }
        public void Demo()
        {
            Console.WriteLine("Enter temperature and wind speed: ");
            double temperature = Convert.ToDouble(Console.ReadLine());
            double windSpeed = Convert.ToDouble(Console.ReadLine());
            double windChill = CalculateWindChill(temperature, windSpeed);
            Console.Write($"Wind Chill Temperature: {windChill}");
        }
    }
}
