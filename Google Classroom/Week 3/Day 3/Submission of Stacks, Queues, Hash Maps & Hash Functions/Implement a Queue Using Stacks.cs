using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_3.Submission_of_Stacks__Queues__Hash_Maps___Hash_Functions
{
    internal class Implement_a_Queue_Using_Stacks
    {
        public static void Main(string[] args)
        {
            Stack<int> s1 = new Stack<int>();
            Stack<int> s2 = new Stack<int>();
            s1.Push(10);
            s1.Push(20);
            s1.Push(30);
            if (s2.Count == 0)
            {
                while (s1.Count > 0)
                    s2.Push(s1.Pop());
            }
            Console.WriteLine("Dequeued: " + s2.Pop());
            s1.Push(40);
            if (s2.Count == 0)
            {
                while (s1.Count > 0)
                    s2.Push(s1.Pop());
            }
            Console.Write("Dequeued: " + s2.Pop());
        }
    }
}
