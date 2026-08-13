using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_3.Submission_of_Stacks__Queues__Hash_Maps___Hash_Functions
{
    internal class Find_All_Subarrays_with_Zero_Sum
    {
        public static void Main(string[] args)
        {
            int[] arr = { 3, 4, -7, 3, 1, 3, 1, -4, -2, -2 };
            Dictionary<int, List<int>> sumMap = new Dictionary<int, List<int>>();
            sumMap[0] = new List<int> { -1 };
            int cumSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                cumSum += arr[i];
                if (sumMap.ContainsKey(cumSum))
                {
                    foreach (int s in sumMap[cumSum])
                        Console.WriteLine($"Subarray from index {s + 1} to {i}");
                    sumMap[cumSum].Add(i);
                }
                else
                {
                    sumMap[cumSum] = new List<int> { i };
                }
            }
            Console.Write("Done.");
        }
    }
}
