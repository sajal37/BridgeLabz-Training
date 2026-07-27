using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._02_C__Methods_Level_1_Practice_Programs
{
    internal class Handshake_Calculation
    {
        public static int CalculateHandshakes(int n)
        {
            return (n * (n - 1)) / 2;
        }
        public void Demo()
        {
            Console.WriteLine("Enter number of students: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());
            int handshakes = CalculateHandshakes(numberOfStudents);
            Console.Write($"Maximum number of possible handshakes: {handshakes}");
        }
    }
}
