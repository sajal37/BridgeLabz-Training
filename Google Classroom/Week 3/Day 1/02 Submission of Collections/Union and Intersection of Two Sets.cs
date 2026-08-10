using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_1._02_Submission_of_Collections
{
    internal class Union_and_Intersection_of_Two_Sets
    {
        public void Demo()
        {
            HashSet<int> Set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> Set2 = new HashSet<int> { 3, 4, 5 };

            HashSet<int> UnionSet = new HashSet<int>(Set1);
            UnionSet.UnionWith(Set2);

            HashSet<int> IntersectSet = new HashSet<int>(Set1);
            IntersectSet.IntersectWith(Set2);

            Console.Write("Union: ");
            foreach (int item in UnionSet)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.Write("Intersection: ");
            foreach (int item in IntersectSet)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
