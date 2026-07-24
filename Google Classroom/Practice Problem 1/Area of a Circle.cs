using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_1
{
    internal class Area_of_a_Circle
    {
        public void Demo()
        {
            int radius = Convert.ToInt32(Console.ReadLine());
            double Area = 3.14 * Math.Pow(radius, 2);
            Console.Write(Area);
        }
    }
}
