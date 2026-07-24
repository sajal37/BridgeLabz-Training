using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_2
{
    internal class Max_Handshakes
    {
        public void Demo()
        {
            Console.Write("Enter number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int handshakes = n * (n - 1) / 2;
            Console.WriteLine($"Handshakes: {handshakes}");
        }
    }
}
