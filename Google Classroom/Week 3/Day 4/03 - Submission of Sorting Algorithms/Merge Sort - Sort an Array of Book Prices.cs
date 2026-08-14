using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_4._03___Submission_of_Sorting_Algorithms
{
    internal class Merge_Sort___Sort_an_Array_of_Book_Prices
    {
        public static void Main(string[] args)
        {
            double[] prices = { 499.50, 299.00, 799.99, 150.25, 350.00 };
            int n = prices.Length;
            MergeSort(prices, 0, n - 1);
            Console.WriteLine("Sorted Book Prices:");
            for (int i = 0; i < n - 1; i++)
                Console.WriteLine(prices[i]);
            Console.Write(prices[n - 1]);
        }
        static void MergeSort(double[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }
        static void Merge(double[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            double[] L = new double[n1];
            double[] R = new double[n2];
            for (int i = 0; i < n1; i++) L[i] = arr[left + i];
            for (int j = 0; j < n2; j++) R[j] = arr[mid + 1 + j];
            int k = left;
            int i1 = 0, j1 = 0;
            while (i1 < n1 && j1 < n2)
            {
                if (L[i1] <= R[j1])
                {
                    arr[k] = L[i1];
                    i1++;
                }
                else
                {
                    arr[k] = R[j1];
                    j1++;
                }
                k++;
            }
            while (i1 < n1)
            {
                arr[k] = L[i1];
                i1++;
                k++;
            }
            while (j1 < n2)
            {
                arr[k] = R[j1];
                j1++;
                k++;
            }
        }
    }
}
