using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._03_C__Methods_Level_2_Practice_Programs
{
    internal class Unit_Converter_Full
    {
        public static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            double farhenheit2celsius = (fahrenheit - 32) * 5 / 9;
            return farhenheit2celsius;
        }
        public static double ConvertCelsiusToFahrenheit(double celsius)
        {
            double celsius2farhenheit = (celsius * 9 / 5) + 32;
            return celsius2farhenheit;
        }
        public static double ConvertPoundsToKg(double pounds)
        {
            double pounds2kilograms = 0.453592;
            return pounds * pounds2kilograms;
        }
        public static double ConvertKgToPounds(double kg)
        {
            double kilograms2pounds = 2.20462;
            return kg * kilograms2pounds;
        }
        public static double ConvertGallonsToLiters(double gallons)
        {
            double gallons2liters = 3.78541;
            return gallons * gallons2liters;
        }
        public static double ConvertLitersToGallons(double liters)
        {
            double liters2gallons = 0.264172;
            return liters * liters2gallons;
        }
        public void Demo()
        {
            Console.Write("Enter Fahrenheit: ");
            double f = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{f} F = {ConvertFahrenheitToCelsius(f)} C");
            Console.Write("Enter Celsius: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{c} C = {ConvertCelsiusToFahrenheit(c)} F");
            Console.Write("Enter pounds: ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{p} lbs = {ConvertPoundsToKg(p)} kg");
            Console.Write("Enter kg: ");
            double kg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{kg} kg = {ConvertKgToPounds(kg)} lbs");
            Console.Write("Enter gallons: ");
            double g = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{g} gallons = {ConvertGallonsToLiters(g)} liters");
            Console.Write("Enter liters: ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.Write($"{l} liters = {ConvertLitersToGallons(l)} gallons");
        }
    }
}
