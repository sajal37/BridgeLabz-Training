using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_4._03___Submission_of_Sorting_Algorithms
{
    internal class Heap_Sort___Sort_Job_Applicants_by_Salary
    {
        public static void Main(string[] args)
        {
            int[] salaries = { 65000, 45000, 90000, 50000, 120000, 80000 };
            int n = salaries.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(salaries, n, i);
            for (int i = n - 1; i > 0; i--)
            {
                int temp = salaries[0];
                salaries[0] = salaries[i];
                salaries[i] = temp;
                Heapify(salaries, i, 0);
            }
            Console.WriteLine("Sorted Expected Salaries:");
            for (int i = 0; i < n - 1; i++)
                Console.WriteLine(salaries[i]);
            Console.Write(salaries[n - 1]);
        }
        static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                Heapify(arr, n, largest);
            }
        }
    }
}
