using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Control_Flow_Level_1_Lab_Practice
{
    internal class Sum_Natural_Numbers_While_Comparison
    {
        public void Demo()
        {
            Console.WriteLine("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                int formulaSum= n * (n + 1) / 2;
                int loopSum = 0;
                int i = 1;
                while (i <= n)
                {
                    loopSum += i;
                    i++;
                }
                Console.WriteLine($"Formula Sum: {formulaSum}");
                Console.WriteLine($"Loop Sum: {loopSum}");
                if (formulaSum == loopSum)
                    Console.Write("Both computations are correct.");
            }
            else
                Console.Write($"{n} is not a natural number.");
        }
    }
}
