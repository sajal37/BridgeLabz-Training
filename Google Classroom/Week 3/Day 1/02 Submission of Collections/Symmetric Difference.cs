using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_1._02_Submission_of_Collections
{
    internal class Symmetric_Difference
    {
        public void Demo()
        {
            HashSet<int> Set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> Set2 = new HashSet<int> { 3, 4, 5 };

            HashSet<int> SymDiff = new HashSet<int>(Set1);
            SymDiff.SymmetricExceptWith(Set2);

            Console.Write("Symmetric Difference: ");
            foreach (int item in SymDiff)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
