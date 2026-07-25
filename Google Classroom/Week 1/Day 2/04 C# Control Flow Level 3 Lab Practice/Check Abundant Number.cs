using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._04_C__Control_Flow_Level_3_Lab_Practice
{
    internal class Check_Abundant_Number
    {
        public void Demo()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum += i;
            }
            if (sum > number)
                Console.Write("Abundant Number");
            else
                Console.Write("Not an Abundant Number");
        }
    }
}
