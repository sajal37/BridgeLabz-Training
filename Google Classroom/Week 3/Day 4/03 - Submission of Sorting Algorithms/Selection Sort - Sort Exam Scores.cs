using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_4._03___Submission_of_Sorting_Algorithms
{
    internal class Selection_Sort___Sort_Exam_Scores
    {
        public static void Main(string[] args)
        {
            int[] scores = { 88, 72, 95, 61, 84, 90 };
            int n = scores.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (scores[j] < scores[minIdx])
                        minIdx = j;
                }
                int temp = scores[minIdx];
                scores[minIdx] = scores[i];
                scores[i] = temp;
            }
            for (int i = 0; i < n; i++) Console.Write(scores[i] + " ");
        }
    }
}
