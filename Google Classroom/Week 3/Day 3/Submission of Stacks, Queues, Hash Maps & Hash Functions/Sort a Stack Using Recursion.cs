using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_3.Submission_of_Stacks__Queues__Hash_Maps___Hash_Functions
{
    internal class Sort_a_Stack_Using_Recursion
    {
        public static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();
            st.Push(3);
            st.Push(1);
            st.Push(4);
            st.Push(2);
            st.Push(5);
            Console.Write("Before: ");
            foreach (int x in st) Console.Write(x + " ");
            Console.WriteLine();
            SortStack(st);
            Console.Write("After: ");
            foreach (int x in st) Console.Write(x + " ");
        }
        static void SortStack(Stack<int> st)
        {
            if (st.Count == 0) return;
            int top = st.Pop();
            SortStack(st);
            Insert(st, top);
        }
        static void Insert(Stack<int> st, int val)
        {
            if (st.Count == 0 || st.Peek() <= val)
            {
                st.Push(val);
                return;
            }
            int top = st.Pop();
            Insert(st, val);
            st.Push(top);
        }
    }
}
