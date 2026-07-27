using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._04_C__Methods_Level_3_Practice_Programs
{
    internal class Collinear_Points_Check
    {
        public static bool IsCollinearBySlope(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double slopeAB = (y2 - y1) / (x2 - x1);
            double slopeBC = (y3 - y2) / (x3 - x2);
            double slopeAC = (y3 - y1) / (x3 - x1);
            return Math.Abs(slopeAB - slopeBC) < 1e-9 && Math.Abs(slopeBC - slopeAC) < 1e-9;
        }
        public static bool IsCollinearByArea(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
            return Math.Abs(area) < 1e-9;
        }
        public void Demo()
        {
            Console.WriteLine("Enter x1 and y1 for A: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2 and y2 for B: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x3 and y3 for C: ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            bool slopeCheck = IsCollinearBySlope(x1, y1, x2, y2, x3, y3);
            bool areaCheck = IsCollinearByArea(x1, y1, x2, y2, x3, y3);
            Console.WriteLine($"Collinear by Slope: {slopeCheck}");
            Console.Write($"Collinear by Area: {areaCheck}");
        }
    }
}
