using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_1._02_Submission_of_Collections
{
    internal class Hospital_Triage_System
    {
        public void Demo()
        {
            PriorityQueue<string, int> triageQueue = new PriorityQueue<string, int>();

            triageQueue.Enqueue("John", -3);
            triageQueue.Enqueue("Alice", -5);
            triageQueue.Enqueue("Bob", -2);

            Console.Write("Treatment Order: ");
            while (triageQueue.Count > 0)
            {
                string patient = triageQueue.Dequeue();
                Console.Write($"{patient} ");
            }
        }
    }
}
