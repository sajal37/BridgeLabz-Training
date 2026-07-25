using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_1
{
    internal class Perimeter_of_a_Rectangle
    {
        public void Demo()
        {
            Console.WriteLine("Enter length and width: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            int Perimeter = 2 * (length + width);
            Console.Write($"Perimeter: {Perimeter}");
        }
    }
}
