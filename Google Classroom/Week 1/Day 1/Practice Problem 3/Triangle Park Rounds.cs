using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_3
{
    internal class Triangle_Park_Rounds
    {
        public void Demo()
        {
            Console.Write("Enter side1 (m): ");
            double s1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side2 (m): ");
            double s2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side3 (m): ");
            double s3 = Convert.ToDouble(Console.ReadLine());
            double perimeter = s1 + s2 + s3;
            double rounds = 5000.0 / perimeter;
            Console.WriteLine($"Rounds: {rounds}");
        }
    }
}
