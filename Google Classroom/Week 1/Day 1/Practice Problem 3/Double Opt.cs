using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_3
{
    internal class Double_Opt
    {
        public void Demo()
        {
            Console.Write("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double r1 = a + b * c;
            double r2 = a * b + c;
            double r3 = c + a / b;
            double r4 = a % b + c;
            Console.WriteLine($"Results: {r1}, {r2}, {r3}, {r4}");
        }
    }
}
