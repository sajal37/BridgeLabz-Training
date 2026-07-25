using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._03_C__Control_Flow_Level_2_Lab_Practice
{
    internal class Grade_Calculation
    {
        public void Demo()
        {
            Console.WriteLine("Enter marks for Physics, Chemistry, Maths: ");
            double physics = Convert.ToDouble(Console.ReadLine());
            double chemistry = Convert.ToDouble(Console.ReadLine());
            double maths = Convert.ToDouble(Console.ReadLine());
            double average = (physics + chemistry + maths) / 3.0;
            string grade;
            string remarks;
            if (average >= 80)
            {
                grade = "A";
                remarks = "(Level 4, above agency-normalized standards)";
            }
            else if (average >= 70)
            {
                grade = "B";
                remarks = "(Level 3, at agency-normalized standards)";
            }
            else if (average >= 60)
            {
                grade = "C";
                remarks = "(Level 2, below, but approaching agency-normalized standards)";
            }
            else if (average >= 50)
            {
                grade = "D";
                remarks = "(Level 1, well below agency-normalized standards)";
            }
            else if (average >= 40)
            {
                grade = "E";
                remarks = "(Level 1- , too below agency-normalized standards)";
            }
            else
            {
                grade = "R";
                remarks = "(Remedial standards)";
            }
            Console.WriteLine($"Average Mark: {average}");
            Console.WriteLine($"Grade: {grade}");
            Console.Write($"Remarks: {remarks}");
        }
    }
}
