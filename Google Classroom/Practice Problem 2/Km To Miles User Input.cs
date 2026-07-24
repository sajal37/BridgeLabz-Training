using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_2
{
    internal class Km_To_Miles_User_Input
    {
        public void Demo()
        {
            Console.Write("Enter distance in km: ");
            double km = Convert.ToDouble(Console.ReadLine());
            double miles = km / 1.6;
            Console.WriteLine($"Miles: {miles}");
        }
    }
}
