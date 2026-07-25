using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Control_Flow_Level_1_Lab_Practice
{
    internal class Employee_Bonus
    {
        public void Demo()
        {
            Console.WriteLine("Enter salary and year of service: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());
            if (year > 5)
            {
                double Bonus= salary * 0.05;
                Console.Write($"Bonus: {Bonus}");
            }
            else
                Console.Write("No bonus");
        }
    }
}
