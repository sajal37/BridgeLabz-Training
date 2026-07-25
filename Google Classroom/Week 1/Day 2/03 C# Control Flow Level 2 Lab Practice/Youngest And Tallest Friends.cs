using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._03_C__Control_Flow_Level_2_Lab_Practice
{
    internal class Youngest_And_Tallest_Friends
    {
        public void Demo()
        {
            Console.WriteLine("Enter age and height for Amar: ");
            int amarAge = Convert.ToInt32(Console.ReadLine());
            double amarHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter age and height for Akbar: ");
            int akbarAge = Convert.ToInt32(Console.ReadLine());
            double akbarHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter age and height for Anthony: ");
            int anthonyAge = Convert.ToInt32(Console.ReadLine());
            double anthonyHeight = Convert.ToDouble(Console.ReadLine());
            string youngest = "Amar";
            int minAge = amarAge;
            if (akbarAge < minAge)
            {
                minAge = akbarAge;
                youngest = "Akbar";
            }
            if (anthonyAge < minAge)
            {
                minAge = anthonyAge;
                youngest = "Anthony";
            }
            string tallest = "Amar";
            double maxHeight = amarHeight;
            if (akbarHeight > maxHeight)
            {
                maxHeight = akbarHeight;
                tallest = "Akbar";
            }
            if (anthonyHeight > maxHeight)
            {
                maxHeight = anthonyHeight;
                tallest = "Anthony";
            }
            Console.WriteLine($"Youngest friend: {youngest} (Age: {minAge})");
            Console.Write($"Tallest friend: {tallest} (Height: {maxHeight})");
        }
    }
}
