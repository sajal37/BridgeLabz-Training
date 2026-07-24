using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_2
{
    internal class Square_Side_From_Perimeter
    {
        public void Demo()
        {
            Console.Write("Enter perimeter of square: ");
            double perimeter = Convert.ToDouble(Console.ReadLine());
            double side = perimeter / 4.0;
            Console.WriteLine($"Side: {side} (Perimeter: {perimeter})");
        }
    }
}
