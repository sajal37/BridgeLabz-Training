using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._03_C__Methods_Level_2_Practice_Programs
{
    internal class Sum_Of_Natural_Numbers_Recursive
    {
        public static int RecursiveSum(int n)
        {
            if (n <= 1)
                return n;
            return n + RecursiveSum(n - 1);
        }
        public static int FormulaSum(int n)
        {
            return n * (n + 1) / 2;
        }
        public void Demo()
        {
            Console.Write("Enter natural number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.Write($"{n} is not a natural number.");
                return;
            }
            int recSum = RecursiveSum(n);
            int formSum = FormulaSum(n);
            Console.WriteLine($"Recursive Sum: {recSum}");
            Console.WriteLine($"Formula Sum: {formSum}");
            if (recSum == formSum)
                Console.Write("Both computations are correct.");
        }
    }
}
