using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_1._02_Submission_of_Collections
{
    internal class Find_Subsets
    {
        public void Demo()
        {
            HashSet<int> Set1 = new HashSet<int> { 2, 3 };
            HashSet<int> Set2 = new HashSet<int> { 1, 2, 3, 4 };

            bool isSubset = Set1.IsSubsetOf(Set2);
            Console.Write($"Is Set1 a subset of Set2: {isSubset}");
        }
    }
}
