using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_3.Submission_of_Stacks__Queues__Hash_Maps___Hash_Functions
{
    internal class Check_for_a_Pair_with_Given_Sum
    {
        public static void Main(string[] args)
        {
            int[] arr = { 8, 7, 2, 5, 3, 1 };
            int target = 10;
            HashSet<int> visited = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int complement = target - arr[i];
                if (visited.Contains(complement))
                    Console.WriteLine($"Pair: {complement} + {arr[i]} = {target}");
                visited.Add(arr[i]);
            }
            Console.Write("Search complete.");
        }
    }
}
