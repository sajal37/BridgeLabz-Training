using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._04_C__Methods_Level_3_Practice_Programs
{
    internal class Number_Checker_Utility_Part_4
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
        public static bool IsNeon(int number)
        {
            long square = (long)number * number;
            long sum = 0;
            while (square != 0)
            {
                sum += square % 10;
                square /= 10;
            }
            return sum == number;
        }
        public static bool IsSpy(int number)
        {
            int temp = Math.Abs(number);
            int sum = 0;
            long product = 1;
            while (temp != 0)
            {
                int rem = temp % 10;
                sum += rem;
                product *= rem;
                temp /= 10;
            }
            return sum == product;
        }
        public static bool IsAutomorphic(int number)
        {
            long square = (long)number * number;
            return square.ToString().EndsWith(number.ToString());
        }
        public static bool IsBuzz(int number)
        {
            return (number % 7 == 0) || (Math.Abs(number) % 10 == 7);
        }
        public void Demo()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Prime: {IsPrime(number)}");
            Console.WriteLine($"Neon: {IsNeon(number)}");
            Console.WriteLine($"Spy: {IsSpy(number)}");
            Console.WriteLine($"Automorphic: {IsAutomorphic(number)}");
            Console.Write($"Buzz: {IsBuzz(number)}");
        }
    }
}
