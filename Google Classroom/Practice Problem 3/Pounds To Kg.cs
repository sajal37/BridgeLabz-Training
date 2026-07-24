using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_3
{
    internal class Pounds_To_Kg
    {
        public void Demo()
        {
            Console.Write("Enter weight (pounds): ");
            double pounds = Convert.ToDouble(Console.ReadLine());
            double kg = pounds * 2.2;
            Console.WriteLine($"Pounds: {pounds}, Kg: {kg}");
        }
    }
}
