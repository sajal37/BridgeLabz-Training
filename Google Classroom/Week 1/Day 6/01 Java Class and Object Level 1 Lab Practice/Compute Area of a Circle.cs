using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Google_Classroom.Week_1.Day_6._01_Java_Class_and_Object_Level_1_Lab_Practice
{
    internal class Compute_Area_of_a_Circle
    {
        public static void Main(string[] args)
        {
            Circle cir1 = new Circle(5);
            cir1.DisplayArea();
            cir1.DisplayCircumference();
        }
    }
    public class Circle
    {
        private int radius;
        public Circle (int radius)
        {
            this.radius = radius;
        }
        public void DisplayCircumference()
        {
            double Cir = 2 * Math.PI * radius; 
            Console.WriteLine($"Circumference of the circle is {Cir}");
        }
        public void DisplayArea()
        {
            double Area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Area of the circle is {Area}");
        }
    }
}
