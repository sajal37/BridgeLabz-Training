using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_1
{
    internal class Volume_of_a_Cylinder
    {
        public void Demo()
        {
            Console.WriteLine("Enter radius: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            double Volume = Math.PI * Math.Pow(radius, 2) * height;
            Console.Write($"Volume: {Volume}");
        }
    }
}
