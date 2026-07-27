using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._02_C__Methods_Level_1_Practice_Programs
{
    internal class Divide_Chocolates
    {
        public static int[] FindRemainderAndQuotient(int number, int divisor)
        {
            int quotient = number / divisor;
            int remainder = number % divisor;
            return new int[] { quotient, remainder };
        }
        public void Demo()
        {
            Console.WriteLine("Enter number of chocolates and children: ");
            int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
            int numberOfChildren = Convert.ToInt32(Console.ReadLine());
            int[] res = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);
            Console.WriteLine($"Chocolates per child: {res[0]}");
            Console.Write($"Remaining chocolates: {res[1]}");
        }
    }
}
