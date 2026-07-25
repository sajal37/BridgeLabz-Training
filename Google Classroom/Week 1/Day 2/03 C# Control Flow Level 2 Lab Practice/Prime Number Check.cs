using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._03_C__Control_Flow_Level_2_Lab_Practice
{
    internal class Prime_Number_Check
    {
        public void Demo()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime && number > 1)
                Console.Write($"{number} is a Prime Number");
            else
                Console.Write($"{number} is not a Prime Number");
        }
    }
}
