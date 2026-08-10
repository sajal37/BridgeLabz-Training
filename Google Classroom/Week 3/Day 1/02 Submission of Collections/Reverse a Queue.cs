using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_1._02_Submission_of_Collections
{
    internal class Reverse_a_Queue
    {
        public void Demo()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);

            Stack<int> st = new Stack<int>();
            while (q.Count > 0)
            {
                st.Push(q.Dequeue());
            }

            while (st.Count > 0)
            {
                q.Enqueue(st.Pop());
            }

            Console.Write("Reversed Queue: ");
            foreach (int item in q)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
