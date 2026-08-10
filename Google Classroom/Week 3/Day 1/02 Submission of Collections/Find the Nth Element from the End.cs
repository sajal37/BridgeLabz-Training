using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_1._02_Submission_of_Collections
{
    internal class Find_the_Nth_Element_from_the_End
    {
        public void Demo()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("A");
            list.AddLast("B");
            list.AddLast("C");
            list.AddLast("D");
            list.AddLast("E");

            int n = 2;

            LinkedListNode<string> fast = list.First;
            LinkedListNode<string> slow = list.First;

            for (int i = 0; i < n; i++)
            {
                if (fast != null)
                {
                    fast = fast.Next;
                }
            }

            while (fast != null)
            {
                fast = fast.Next;
                slow = slow.Next;
            }

            Console.Write($"The {n}th element from the end is: {slow.Value}");
        }
    }
}
