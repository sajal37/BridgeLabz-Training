using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Text;

namespace Google_Classroom.Week_4.Day_3._06__Submission_of_Algorithm_s_Runtime_Analysis___Big_O_Notation
{
    internal class Sorting_Large_Data_Efficiently
    {
        public static void Main(string[] args)
        {
            int[] sizes = { 1000, 10000 };
            foreach (int n in sizes)
            {
                int[] baseArr = new int[n];
                Random rand = new Random(42);
                for (int i = 0; i < n; i++) baseArr[i] = rand.Next(1, 100000);
                int[] arr1 = (int[])baseArr.Clone();
                int[] arr2 = (int[])baseArr.Clone();
                int[] arr3 = (int[])baseArr.Clone();
                Stopwatch sw1 = Stopwatch.StartNew();
                BubbleSort(arr1);
                sw1.Stop();
                Stopwatch sw2 = Stopwatch.StartNew();
                MergeSort(arr2, 0, arr2.Length - 1);
                sw2.Stop();
                Stopwatch sw3 = Stopwatch.StartNew();
                QuickSort(arr3, 0, arr3.Length - 1);
                sw3.Stop();
                Console.WriteLine($"Size: {n} | Bubble: {sw1.ElapsedMilliseconds}ms | Merge: {sw2.ElapsedMilliseconds}ms | Quick: {sw3.ElapsedMilliseconds}ms");
            }
        }
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }
        static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (int i = 0; i < n1; i++) L[i] = arr[left + i];
            for (int j = 0; j < n2; j++) R[j] = arr[mid + 1 + j];
            int k = left, i1 = 0, j1 = 0;
            while (i1 < n1 && j1 < n2)
            {
                if (L[i1] <= R[j1]) { arr[k] = L[i1]; i1++; }
                else { arr[k] = R[j1]; j1++; }
                k++;
            }
            while (i1 < n1) { arr[k] = L[i1]; i1++; k++; }
            while (j1 < n2) { arr[k] = R[j1]; j1++; k++; }
        }
        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }
        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;
            return i + 1;
        }
    }
}
