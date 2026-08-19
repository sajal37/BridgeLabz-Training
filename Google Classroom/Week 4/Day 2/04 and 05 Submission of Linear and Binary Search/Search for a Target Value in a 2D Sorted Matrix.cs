using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_4.Day_2._04_and_05_Submission_of_Linear_and_Binary_Search
{
    internal class Search_for_a_Target_Value_in_a_2D_Sorted_Matrix
    {
        public static void Main(string[] args)
        {
            int[,] matrix = {
                { 1, 3, 5, 7 },
                { 10, 11, 16, 20 },
                { 23, 30, 34, 60 }
            };
            int target = 16;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int low = 0;
            int high = rows * cols - 1;
            int foundRow = -1;
            int foundCol = -1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                int r = mid / cols;
                int c = mid % cols;
                if (matrix[r, c] == target)
                {
                    foundRow = r;
                    foundCol = c;
                    break;
                }
                else if (matrix[r, c] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            if (foundRow != -1)
                Console.WriteLine($"Found {target} at row {foundRow}, col {foundCol}");
        }
    }
}
