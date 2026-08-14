using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_4._03___Submission_of_Sorting_Algorithms
{
    internal class Bubble_Sort___Sort_Student_Marks
    {
        public static void Main(string[] args)
        {
            int[] marks = { 78, 45, 89, 92, 63, 54, 81 };
            int n = marks.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (marks[j] > marks[j + 1])
                    {
                        int temp = marks[j];
                        marks[j] = marks[j + 1];
                        marks[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted Student Marks:");
            for (int i = 0; i < n - 1; i++)
                Console.WriteLine(marks[i]);
            Console.Write(marks[n - 1]);
        }
    }
}
