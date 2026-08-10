using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_1._02_Submission_of_Collections
{
    internal class Reverse_a_List
    {
        public void Demo()
        {
            ArrayList list1 = new ArrayList();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);

            ArrayList revList = new ArrayList();
            for (int i = list1.Count - 1; i >= 0; i--)
            {
                revList.Add(list1[i]);
            }

            Console.Write("ArrayList Reversed: ");
            for (int i = 0; i < revList.Count; i++)
            {
                Console.Write($"{revList[i]} ");
            }
            Console.WriteLine();

            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);

            LinkedList<int> revLinked = new LinkedList<int>();
            foreach (int num in linkedList)
            {
                revLinked.AddFirst(num);
            }

            Console.Write("LinkedList Reversed: ");
            foreach (int num in revLinked)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
