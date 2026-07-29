using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_5.Problem_Statment
{
    internal class Factorial_Using_Recursion
    {
        public static long CalculateFactorial(int n)
        {
            if (n <= 1)
                return 1;
            return n * CalculateFactorial(n - 1);
        }
        public void Demo()
        {
            Console.Write("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            long fact = CalculateFactorial(n);
            Console.Write($"Factorial of {n}: {fact}");
        }
    }
}
