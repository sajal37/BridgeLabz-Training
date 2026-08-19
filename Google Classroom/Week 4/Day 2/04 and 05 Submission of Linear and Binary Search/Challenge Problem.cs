using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_4.Day_2._04_and_05_Submission_of_Linear_and_Binary_Search
{
    internal class Challenge_Problem
    {
        public static void Main(string[] args)
        {
            int[] nums = { 3, 4, -1, 1, 7, 2, 8 };
            int target = 7;
            int n = nums.Length;
            bool[] seen = new bool[n + 2];
            for (int i = 0; i < n; i++)
            {
                if (nums[i] > 0 && nums[i] <= n + 1)
                    seen[nums[i]] = true;
            }
            int missing = 1;
            for (int i = 1; i <= n + 1; i++)
            {
                if (!seen[i])
                {
                    missing = i;
                    break;
                }
            }
            Console.WriteLine($"First Missing Positive: {missing}");
            Array.Sort(nums);
            int low = 0;
            int high = nums.Length - 1;
            int targetIdx = -1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid] == target)
                {
                    targetIdx = mid;
                    break;
                }
                else if (nums[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            Console.Write($"Target Index: {targetIdx}");
        }
    }
}
