using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_3.Submission_of_Stacks__Queues__Hash_Maps___Hash_Functions
{
    internal class Stock_Span_Problem
    {
        public static void Main(string[] args)
        {
            int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
            int n = prices.Length;
            int[] Span = new int[n];
            Stack<int> st = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                while (st.Count > 0 && prices[st.Peek()] <= prices[i])
                    st.Pop();
                Span[i] = st.Count == 0 ? i + 1 : i - st.Peek();
                st.Push(i);
            }
            for (int i = 0; i < n; i++) Console.Write(Span[i] + " ");
        }
    }
}
