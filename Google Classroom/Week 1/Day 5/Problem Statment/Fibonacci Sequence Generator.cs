using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_5.Problem_Statment
{
    internal class Fibonacci_Sequence_Generator
    {
        public static void GenerateFibonacci(int terms)
        {
            int first = 0, second = 1;
            Console.Write("Fibonacci Sequence: ");
            for (int i = 1; i <= terms; i++)
            {
                Console.Write($"{first} ");
                int next = first + second;
                first = second;
                second = next;
            }
        }
        public void Demo()
        {
            Console.Write("Enter number of terms: ");
            int terms = Convert.ToInt32(Console.ReadLine());
            GenerateFibonacci(terms);
        }
    }
}
