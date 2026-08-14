using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_3.Submission_of_Stacks__Queues__Hash_Maps___Hash_Functions
{
    internal class Sliding_Window_Maximum
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;
            int n = arr.Length;
            int[] Result = new int[n - k + 1];
            LinkedList<int> dq = new LinkedList<int>();
            for (int i = 0; i < n; i++)
            {
                while (dq.Count > 0 && dq.First.Value < i - k + 1)
                    dq.RemoveFirst();
                while (dq.Count > 0 && arr[dq.Last.Value] <= arr[i])
                    dq.RemoveLast();
                dq.AddLast(i);
                if (i >= k - 1)
                    Result[i - k + 1] = arr[dq.First.Value];
            }
            for (int i = 0; i < Result.Length; i++) Console.Write(Result[i] + " ");
        }
    }
}
