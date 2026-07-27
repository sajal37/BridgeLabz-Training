using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._04_C__Methods_Level_3_Practice_Programs
{
    internal class Number_Checker_Utility_Part_5
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
        public static int FindGreatestFactor(int[] factors)
        {
            if (factors.Length <= 1)
                return 1;
            return factors[factors.Length - 2];
        }
        public static int FindSumOfFactors(int[] factors)
        {
            int sum = 0;
            for (int i = 0; i < factors.Length; i++)
            {
                sum += factors[i];
            }
            return sum;
        }
        public static long FindProductOfFactors(int[] factors)
        {
            long product = 1;
            for (int i = 0; i < factors.Length; i++)
            {
                product *= factors[i];
            }
            return product;
        }
        public static double FindProductOfCubes(int[] factors)
        {
            double product = 1;
            for (int i = 0; i < factors.Length; i++)
            {
                product *= Math.Pow(factors[i], 3);
            }
            return product;
        }
        public static bool IsPerfect(int number, int[] factors)
        {
            int properSum = FindSumOfFactors(factors) - number;
            return properSum == number;
        }
        public static bool IsAbundant(int number, int[] factors)
        {
            int properSum = FindSumOfFactors(factors) - number;
            return properSum > number;
        }
        public static bool IsDeficient(int number, int[] factors)
        {
            int properSum = FindSumOfFactors(factors) - number;
            return properSum < number;
        }
        public static bool IsStrong(int number)
        {
            int temp = number;
            int sum = 0;
            while (temp != 0)
            {
                int rem = temp % 10;
                int fact = 1;
                for (int i = 1; i <= rem; i++)
                {
                    fact *= i;
                }
                sum += fact;
                temp /= 10;
            }
            return sum == number;
        }
        public void Demo()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] factors = FindFactors(number);
            int greatest = FindGreatestFactor(factors);
            int sum = FindSumOfFactors(factors);
            long prod = FindProductOfFactors(factors);
            double prodCubes = FindProductOfCubes(factors);
            bool perfect = IsPerfect(number, factors);
            bool abundant = IsAbundant(number, factors);
            bool deficient = IsDeficient(number, factors);
            bool strong = IsStrong(number);
            Console.WriteLine($"Greatest factor: {greatest}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {prod}");
            Console.WriteLine($"Product of cubes: {prodCubes}");
            Console.WriteLine($"Perfect: {perfect}");
            Console.WriteLine($"Abundant: {abundant}");
            Console.WriteLine($"Deficient: {deficient}");
            Console.Write($"Strong: {strong}");
        }
    }
}
