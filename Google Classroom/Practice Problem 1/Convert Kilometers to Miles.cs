using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Google_Classroom.Practice_Problem_1
{
    internal class Convert_Kilometers_to_Miles
    {
        public void Demo()
        {
            Console.WriteLine("Enter distance in kilometers: ");
            double kilometers = Convert.ToDouble(Console.ReadLine());
            double miles = kilometers * 0.621371;
            Console.Write($"Distance in miles: {miles}");
        }
    }
}
