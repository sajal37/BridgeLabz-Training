using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_4.Day_2._04_and_05_Submission_of_Linear_and_Binary_Search
{
    internal class Find_the_Rotation_Point_in_a_Rotated_Sorted_Array
    {
        public static void Main(string[] args)
        {
            int[] arr = { 4, 5, 6, 7, 0, 1, 2 };
            int low = 0;
            int high = arr.Length - 1;
            while (low < high)
            {
                int mid = low + (high - low) / 2;
                if (arr[mid] > arr[high])
                    low = mid + 1;
                else
                    high = mid;
            }
            Console.WriteLine($"Rotation Point Index: {low}");
            Console.Write($"Smallest Element: {arr[low]}");
        }
    }
}
