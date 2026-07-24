using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_2
{
    internal class Feet_To_Yards_Miles
    {
        public void Demo()
        {
            Console.Write("Enter distance in feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());
            double yards = feet / 3.0;
            double miles = yards / 1760.0;
            Console.WriteLine($"Yards: {yards}, Miles: {miles}");
        }
    }
}
