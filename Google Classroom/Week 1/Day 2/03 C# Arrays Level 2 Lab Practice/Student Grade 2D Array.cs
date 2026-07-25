using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._03_C__Arrays_Level_2_Lab_Practice
{
    internal class Student_Grade_2D_Array
    {
        public void Demo()
        {
            Console.WriteLine("Enter number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] marks = new double[n, 3];
            double[] percentages = new double[n];
            string[] grades = new string[n];
            string[] remarks = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter Physics, Chemistry, Maths marks for student {i + 1}: ");
                double p = Convert.ToDouble(Console.ReadLine());
                double c = Convert.ToDouble(Console.ReadLine());
                double m = Convert.ToDouble(Console.ReadLine());
                if (p < 0 || c < 0 || m < 0)
                {
                    i--;
                    continue;
                }
                marks[i, 0] = p;
                marks[i, 1] = c;
                marks[i, 2] = m;
                percentages[i] = (p + c + m) / 3.0;
                double avg = percentages[i];
                if (avg >= 80)
                {
                    grades[i] = "A";
                    remarks[i] = "(Level 4, above agency-normalized standards)";
                }
                else if (avg >= 70)
                {
                    grades[i] = "B";
                    remarks[i] = "(Level 3, at agency-normalized standards)";
                }
                else if (avg >= 60)
                {
                    grades[i] = "C";
                    remarks[i] = "(Level 2, below, but approaching agency-normalized standards)";
                }
                else if (avg >= 50)
                {
                    grades[i] = "D";
                    remarks[i] = "(Level 1, well below agency-normalized standards)";
                }
                else if (avg >= 40)
                {
                    grades[i] = "E";
                    remarks[i] = "(Level 1- , too below agency-normalized standards)";
                }
                else
                {
                    grades[i] = "R";
                    remarks[i] = "(Remedial standards)";
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Student {i + 1} - Marks: P={marks[i, 0]}, C={marks[i, 1]}, M={marks[i, 2]} | Percentage: {percentages[i]}% | Grade: {grades[i]} | Remarks: {remarks[i]}");
            }
        }
    }
}
