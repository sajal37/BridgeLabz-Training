using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._04_C__Control_Flow_Level_3_Lab_Practice
{
    internal class Check_Armstrong_Number
    {
        public void Demo()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int originalNumber = number;
            int sum = 0;
            while (originalNumber != 0)
            {
                int remainder = originalNumber % 10;
                sum += remainder * remainder * remainder;
                originalNumber /= 10;
            }
            if (number == sum)
                Console.Write($"{number} is an Armstrong Number");
            else
                Console.Write($"{number} is not an Armstrong Number");
        }
    }
}
