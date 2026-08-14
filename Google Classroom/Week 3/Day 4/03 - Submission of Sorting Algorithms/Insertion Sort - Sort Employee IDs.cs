using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Google_Classroom.Week_3.Day_4._03___Submission_of_Sorting_Algorithms
{
    internal class Insertion_Sort___Sort_Employee_IDs
    {
        public static void Main(string[] args)
        {
            int[] empIds = { 105, 102, 108, 101, 104, 107 };
            for (int i = 1; i < empIds.Length; i++)
            {
                int key = empIds[i];
                int j = i - 1;
                while (j >= 0 && empIds[j] > key)
                {
                    empIds[j + 1] = empIds[j];
                    j--;
                }
                empIds[j + 1] = key;
            }
            Console.Write(string.Join(" ", empIds));
        }
    }
}
