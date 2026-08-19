using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Google_Classroom.Week_4.Day_3._06__Submission_of_Algorithm_s_Runtime_Analysis___Big_O_Notation
{
    internal class Search_a_Target_in_a_Large_Dataset
    {
        public static void Main(string[] args)
        {
            int[] sizes = { 1000, 10000, 1000000 };
            int target = 999999;
            foreach (int n in sizes)
            {
                int[] arr = new int[n];
                for (int i = 0; i < n; i++) arr[i] = i;
                Stopwatch sw1 = Stopwatch.StartNew();
                int idx1 = LinearSearch(arr, target);
                sw1.Stop();
                long linTime = sw1.ElapsedTicks;
                Stopwatch sw2 = Stopwatch.StartNew();
                int idx2 = BinarySearch(arr, target);
                sw2.Stop();
                long binTime = sw2.ElapsedTicks;
                Console.WriteLine($"Size: {n} | Linear: {linTime} ticks | Binary: {binTime} ticks");
            }
        }
        static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target) return i;
            }
            return -1;
        }
        static int BinarySearch(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (arr[mid] == target) return mid;
                if (arr[mid] < target) low = mid + 1;
                else high = mid - 1;
            }
            return -1;
        }
    }
}
