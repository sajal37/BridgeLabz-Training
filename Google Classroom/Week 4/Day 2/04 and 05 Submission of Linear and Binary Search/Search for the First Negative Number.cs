using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_4.Day_2._04_and_05_Submission_of_Linear_and_Binary_Search
{
    internal class Search_for_the_First_Negative_Number
    {
        public static void Main(string[] args)
        {
            int[] arr = { 12, 45, 19, -5, 23, -8, 7 };
            int firstNeg = 0;
            int idx = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    firstNeg = arr[i];
                    idx = i;
                    break;
                }
            }
            if (idx != -1)
                Console.WriteLine($"Found {firstNeg} at index {idx}");
        }
    }
}
