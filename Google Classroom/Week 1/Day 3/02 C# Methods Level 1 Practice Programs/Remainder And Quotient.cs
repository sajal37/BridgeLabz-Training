using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._02_C__Methods_Level_1_Practice_Programs
{
    internal class Remainder_And_Quotient
    {
        public static int[] FindRemainderAndQuotient(int number, int divisor)
        {
            int quotient = number / divisor;
            int remainder = number % divisor;
            return new int[] { quotient, remainder };
        }
        public void Demo()
        {
            Console.WriteLine("Enter number and divisor: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int divisor = Convert.ToInt32(Console.ReadLine());
            int[] res = FindRemainderAndQuotient(number, divisor);
            Console.WriteLine($"Quotient: {res[0]}");
            Console.Write($"Remainder: {res[1]}");
        }
    }
}
