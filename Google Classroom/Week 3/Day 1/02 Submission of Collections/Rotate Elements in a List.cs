using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_1._02_Submission_of_Collections
{
    internal class Rotate_Elements_in_a_List
    {
        public void Demo()
        {
            List<int> Numbers = new List<int> { 10, 20, 30, 40, 50 };
            int rotateBy = 2;

            List<int> Rotated = new List<int>();
            int n = Numbers.Count;

            for (int i = 0; i < n; i++)
            {
                int newIndex = (i + rotateBy) % n;
                Rotated.Add(Numbers[newIndex]);
            }

            Console.Write("Rotated List: ");
            for (int i = 0; i < Rotated.Count; i++)
            {
                Console.Write($"{Rotated[i]} ");
            }
        }
    }
}
