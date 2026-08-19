using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Google_Classroom.Week_4.Day_3._06__Submission_of_Algorithm_s_Runtime_Analysis___Big_O_Notation
{
    internal class Recursive_vs_Iterative_Fibonacci_Computation
    {
        public static void Main(string[] args)
        {
            int[] values = { 10, 30, 40 };
            foreach (int n in values)
            {
                Stopwatch sw1 = Stopwatch.StartNew();
                long rVal = FibonacciRecursive(n);
                sw1.Stop();
                long recTime = sw1.ElapsedMilliseconds;
                Stopwatch sw2 = Stopwatch.StartNew();
                long iVal = FibonacciIterative(n);
                sw2.Stop();
                long iterTime = sw2.ElapsedMilliseconds;
                Console.WriteLine($"N={n} | Recursive: {recTime}ms (val={rVal}) | Iterative: {iterTime}ms (val={iVal})");
            }
        }
        public static long FibonacciRecursive(int n)
        {
            if (n <= 1) return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
        public static long FibonacciIterative(int n)
        {
            if (n <= 1) return n;
            long a = 0, b = 1, sum;
            for (int i = 2; i <= n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return b;
        }
    }
}
