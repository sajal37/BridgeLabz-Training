using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Arrays_Level_1_Lab_Practice
{
    internal class Student_Voting_Eligibility_Array
    {
        public void Demo()
        {
            int[] ages = new int[10];
            Console.WriteLine("Enter ages of 10 students: ");
            for (int i = 0; i < ages.Length; i++)
            {
                ages[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] < 0)
                    Console.WriteLine("Invalid age");
                else if (ages[i] >= 18)
                    Console.WriteLine($"The student with the age {ages[i]} can vote.");
                else
                    Console.WriteLine($"The student with the age {ages[i]} cannot vote.");
            }
        }
    }
}
