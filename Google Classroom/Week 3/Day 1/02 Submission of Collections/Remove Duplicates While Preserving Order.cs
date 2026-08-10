using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_1._02_Submission_of_Collections
{
    internal class Remove_Duplicates_While_Preserving_Order
    {
        public void Demo()
        {
            List<int> numbers = new List<int> { 3, 1, 2, 2, 3, 4 };
            List<int> uniqueList = new List<int>();

            foreach (int num in numbers)
            {
                if (!uniqueList.Contains(num))
                {
                    uniqueList.Add(num);
                }
            }

            Console.Write("List after removing duplicates: ");
            foreach (int num in uniqueList)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
