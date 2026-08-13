using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_3.Submission_of_Stacks__Queues__Hash_Maps___Hash_Functions
{
    internal class Circular_Tour_Problem
    {
        public static void Main(string[] args)
        {
            int[] petrol = { 4, 6, 7, 4 };
            int[] distance = { 6, 5, 3, 5 };
            int n = petrol.Length;
            int start = 0;
            int surplus = 0;
            int deficit = 0;
            for (int i = 0; i < n; i++)
            {
                surplus += petrol[i] - distance[i];
                if (surplus < 0)
                {
                    deficit += surplus;
                    surplus = 0;
                    start = i + 1;
                }
            }
            if (surplus + deficit >= 0)
                Console.Write($"Starting pump: {start + 1}");
            else
                Console.Write("No solution exists.");
        }
    }
}
