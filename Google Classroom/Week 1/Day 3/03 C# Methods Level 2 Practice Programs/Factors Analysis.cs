using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._03_C__Methods_Level_2_Practice_Programs
{
    internal class Factors_Analysis
    {
        public static int[] FindFactors(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    count++;
            }
            int[] factors = new int[count];
            int index = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors[index] = i;
                    index++;
                }
            }
            return factors;
        }
        public static int FindSum(int[] factors)
        {
            int sum = 0;
            for (int i = 0; i < factors.Length; i++)
            {
                sum += factors[i];
            }
            return sum;
        }
        public static double FindSumOfSquares(int[] factors)
        {
            double sumSq = 0;
            for (int i = 0; i < factors.Length; i++)
            {
                sumSq += Math.Pow(factors[i], 2);
            }
            return sumSq;
        }
        public static long FindProduct(int[] factors)
        {
            long product = 1;
            for (int i = 0; i < factors.Length; i++)
            {
                product *= factors[i];
            }
            return product;
        }
        public void Demo()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] factors = FindFactors(number);
            Console.WriteLine("Factors:");
            for (int i = 0; i < factors.Length; i++)
            {
                Console.WriteLine(factors[i]);
            }
            int sum = FindSum(factors);
            double sumSq = FindSumOfSquares(factors);
            long product = FindProduct(factors);
            Console.WriteLine($"Sum of factors: {sum}");
            Console.WriteLine($"Sum of square of factors: {sumSq}");
            Console.Write($"Product of factors: {product}");
        }
    }
}
