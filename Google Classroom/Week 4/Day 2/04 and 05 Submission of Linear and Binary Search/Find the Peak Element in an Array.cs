using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_4.Day_2._04_and_05_Submission_of_Linear_and_Binary_Search
{
    internal class Find_the_Peak_Element_in_an_Array
    {
        public static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 1 };
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] > nums[mid + 1])
                    right = mid;
                else
                    left = mid + 1;
            }
            Console.WriteLine($"Peak Element: {nums[left]}");
            Console.Write($"Index: {left}");
        }
    }
}
