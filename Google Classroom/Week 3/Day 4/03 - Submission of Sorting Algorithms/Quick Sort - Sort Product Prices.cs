using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_4._03___Submission_of_Sorting_Algorithms
{
    internal class Quick_Sort___Sort_Product_Prices
    {
        public static void Main(string[] args)
        {
            double[] prices = { 1299.00, 499.99, 89.50, 2499.00, 150.00, 750.25 };
            QuickSort(prices, 0, prices.Length - 1);
            for (int i = 0; i < prices.Length; i++) Console.Write(prices[i] + " ");
        }
        static void QuickSort(double[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }
        static int Partition(double[] arr, int low, int high)
        {
            double pivot = arr[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    double temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            double temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;
            return i + 1;
        }
    }
}
