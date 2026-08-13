using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_3.Submission_of_Stacks__Queues__Hash_Maps___Hash_Functions
{
    internal class Two_Sum_Problem
    {
        public static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            Dictionary<int, int> indexMap = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (indexMap.ContainsKey(complement))
                {
                    Console.Write($"Indices: [{indexMap[complement]}, {i}]");
                    return;
                }
                indexMap[nums[i]] = i;
            }
            Console.Write("No pair found.");
        }
    }
}
