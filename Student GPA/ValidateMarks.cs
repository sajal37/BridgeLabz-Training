using System;
using System.Collections.Generic;
using System.Text;

namespace Student_GPA
{
    public class ValidateMarks
    {
        public void Marks()
        {
            int[] marks = { 88, 76, 105, 65, -10, 70, 60 };
            foreach (int m in marks)
            {
                if (m > 0) Console.WriteLine("valid");
                else throw new InvalidMarksException(m);
            }
        }
    }
}
