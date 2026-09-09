using System;
using System.Collections.Generic;
using System.Text;

namespace Student_GPA
{
    public class DetectDuplicate
    {
        public void Detect()
        {
            HashSet<string> set= new HashSet<string>();
            foreach(string line in File.ReadAllLines("students.csv"))
            {
                string[] arr = line.Split(',');
                string key = arr[0] + arr[2];
                if (set.Contains(key)) throw new DuplicateSubjectRecordException(key);
                else set.Add(key);
            }
        }
    }
}
