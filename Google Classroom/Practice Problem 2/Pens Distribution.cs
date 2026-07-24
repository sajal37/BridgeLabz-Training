using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_2
{
    internal class Pens_Distribution
    {
        public void Demo()
        {
            int totalPens = 14;
            int students = 3;
            int perStudent = totalPens / students;
            int remaining = totalPens % students;
            Console.WriteLine($"Per student: {perStudent}, Remaining: {remaining}");
        }
    }
}
