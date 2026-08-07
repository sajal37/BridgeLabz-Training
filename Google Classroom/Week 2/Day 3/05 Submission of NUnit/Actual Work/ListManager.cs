using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Actual_Work
{
    public class ListManager
    {
        public void AddElement(List<int> list, int element)
        {
            if (list != null)
                list.Add(element);
        }

        public void RemoveElement(List<int> list, int element)
        {
            if (list != null)
                list.Remove(element);
        }

        public int GetSize(List<int> list)
        {
            if (list == null)
                return 0;
            int Size = list.Count;
            return Size;
        }
    }
}
