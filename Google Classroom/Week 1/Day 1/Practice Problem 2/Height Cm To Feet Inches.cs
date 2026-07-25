using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_2
{
    internal class Height_Cm_To_Feet_Inches
    {
        public void Demo()
        {
            Console.Write("Enter height in cm: ");
            double cm = Convert.ToDouble(Console.ReadLine());
            double totalInches = cm / 2.54;
            int feet = (int)(totalInches / 12);
            double inches = totalInches - feet * 12;
            Console.WriteLine($"cm: {cm}, ft: {feet}, in: {inches}");
        }
    }
}
