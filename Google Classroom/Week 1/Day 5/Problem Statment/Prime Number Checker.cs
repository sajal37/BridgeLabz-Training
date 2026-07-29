using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_5.Problem_Statment
{
    internal class Prime_Number_Checker
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        public void Demo()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (IsPrime(number))
                Console.Write($"{number} is a prime number.");
            else
                Console.Write($"{number} is not a prime number.");
        }
    }
}
