using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_1._02_Submission_of_Collections
{
    internal class Generate_Binary_Numbers_Using_a_Queue
    {
        public void Demo()
        {
            int n = 5;
            Queue<string> q = new Queue<string>();
            q.Enqueue("1");

            Console.Write("Binary Numbers: ");
            for (int i = 0; i < n; i++)
            {
                string curr = q.Dequeue();
                Console.Write($"{curr} ");

                q.Enqueue(curr + "0");
                q.Enqueue(curr + "1");
            }
        }
    }
}
