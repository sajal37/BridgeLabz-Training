using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._04_C__Control_Flow_Level_3_Lab_Practice
{
    internal class Check_Harshad_Number
    {
        public void Demo()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int temp = number;
            int sum = 0;
            while (temp != 0)
            {
                int remainder = temp % 10;
                sum += remainder;
                temp /= 10;
            }
            if (number % sum == 0)
                Console.Write("Harshad Number");
            else
                Console.Write("Not a Harshad Number");
        }
    }
}
