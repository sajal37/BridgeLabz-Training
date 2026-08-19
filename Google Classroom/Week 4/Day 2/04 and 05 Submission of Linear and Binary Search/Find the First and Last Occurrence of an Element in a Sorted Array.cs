using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_4.Day_2._04_and_05_Submission_of_Linear_and_Binary_Search
{
    internal class Find_the_First_and_Last_Occurrence_of_an_Element_in_a_Sorted_Array
    {
        public static void Main(string[] args)
        {
            int[] nums = { 5, 7, 7, 8, 8, 8, 10 };
            int target = 8;
            int first = FindFirst(nums, target);
            int last = FindLast(nums, target);
            Console.WriteLine($"First Occurrence: {first}");
            Console.Write($"Last Occurrence: {last}");
        }
        static int FindFirst(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;
            int res = -1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (arr[mid] == target)
                {
                    res = mid;
                    high = mid - 1;
                }
                else if (arr[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return res;
        }
        static int FindLast(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;
            int res = -1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (arr[mid] == target)
                {
                    res = mid;
                    low = mid + 1;
                }
                else if (arr[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return res;
        }
    }
}
