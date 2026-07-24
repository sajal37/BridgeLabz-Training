using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_2
{
    internal class Triangle_Area_Inches_Cm
    {
        public void Demo()
        {
            Console.Write("Enter base (in inches): ");
            double baseIn = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height (in inches): ");
            double heightIn = Convert.ToDouble(Console.ReadLine());
            double areaSqIn = 0.5 * baseIn * heightIn;
            double areaSqCm = areaSqIn * 2.54 * 2.54;
            Console.WriteLine($"Area (in^2): {areaSqIn}, (cm^2): {areaSqCm}");
        }
    }
}
