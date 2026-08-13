using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_3.Submission_of_Stacks__Queues__Hash_Maps___Hash_Functions
{
    internal class Longest_Consecutive_Sequence
    {
        public static void Main(string[] args)
        {
            int[] arr = { 100, 4, 200, 1, 3, 2 };
            HashSet<int> numSet = new HashSet<int>(arr);
            int LongestLen = 0;
            foreach (int num in numSet)
            {
                if (!numSet.Contains(num - 1))
                {
                    int curr = num;
                    int len = 1;
                    while (numSet.Contains(curr + 1))
                    {
                        curr++;
                        len++;
                    }
                    if (len > LongestLen) LongestLen = len;
                }
            }
            Console.Write($"Longest consecutive sequence length: {LongestLen}");
        }
    }
}
