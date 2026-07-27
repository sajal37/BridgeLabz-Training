using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._02_C__Methods_Level_1_Practice_Programs
{
    internal class Simple_Interest
    {
        public static double CalculateSimpleInterest(double principal, double rate, double time)
        {
            return (principal * rate * time) / 100;
        }
        public void Demo()
        {
            Console.WriteLine("Enter principal, rate and time: ");
            double principal = Convert.ToDouble(Console.ReadLine());
            double rate = Convert.ToDouble(Console.ReadLine());
            double time = Convert.ToDouble(Console.ReadLine());
            double si = CalculateSimpleInterest(principal, rate, time);
            Console.Write($"The Simple Interest is {si} for Principal {principal}, Rate of Interest {rate} and Time {time}");
        }
    }
}
