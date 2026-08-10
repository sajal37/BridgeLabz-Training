using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_1._02_Submission_of_Collections
{
    internal class Check_if_Two_Sets_Are_Equal
    {
        public void Demo()
        {
            HashSet<int> Set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> Set2 = new HashSet<int> { 3, 2, 1 };

            bool isEqual = Set1.SetEquals(Set2);
            Console.Write($"Are sets equal: {isEqual}");
        }
    }
}
