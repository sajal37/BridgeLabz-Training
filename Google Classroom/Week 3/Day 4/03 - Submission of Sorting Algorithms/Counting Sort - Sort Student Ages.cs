using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_4._03___Submission_of_Sorting_Algorithms
{
    internal class Counting_Sort___Sort_Student_Ages
    {
        public static void Main(string[] args)
        {
            int[] ages = { 14, 11, 18, 10, 15, 12, 16, 11, 10, 17, 13, 18 };
            int n = ages.Length;
            int minAge = 10;
            int maxAge = 18;
            int range = maxAge - minAge + 1;
            int[] count = new int[range];
            int[] output = new int[n];
            for (int i = 0; i < n; i++)
                count[ages[i] - minAge]++;
            for (int i = 1; i < range; i++)
                count[i] += count[i - 1];
            for (int i = n - 1; i >= 0; i--)
            {
                output[count[ages[i] - minAge] - 1] = ages[i];
                count[ages[i] - minAge]--;
            }
            for (int i = 0; i < n; i++) Console.Write(output[i] + " ");
        }
    }
}
