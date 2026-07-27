using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._03_C__Methods_Level_2_Practice_Programs
{
    internal class Student_Vote_Checker
    {
        public static bool CanStudentVote(int age)
        {
            if (age < 0)
                return false;
            if (age >= 18)
                return true;
            return false;
        }
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
                    Console.WriteLine($"Student {i + 1} (age {ages[i]}): invalid age");
                else if (CanStudentVote(ages[i]))
                    Console.WriteLine($"Student {i + 1} (age {ages[i]}): can vote");
                else
                    Console.WriteLine($"Student {i + 1} (age {ages[i]}): cannot vote");
            }
        }
    }
}
