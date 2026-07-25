using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_3
{
    internal class Simple_Interest
    {
        public void Demo()
        {
            Console.Write("Enter principal: ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter rate (%): ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter time (years): ");
            double t = Convert.ToDouble(Console.ReadLine());
            double si = (p * r * t) / 100.0;
            Console.WriteLine($"Simple Interest: {si}");
        }
    }
}
