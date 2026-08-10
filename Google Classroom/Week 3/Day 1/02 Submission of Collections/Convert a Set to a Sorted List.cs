using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_1._02_Submission_of_Collections
{
    internal class Convert_a_Set_to_a_Sorted_List
    {
        public void Demo()
        {
            HashSet<int> set = new HashSet<int> { 5, 3, 9, 1 };

            List<int> sortedList = new List<int>(set);
            sortedList.Sort();

            Console.Write("Sorted List: ");
            foreach (int num in sortedList)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
