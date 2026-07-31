using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_7._03_this__sealed__static_key_words_and_is_Operator_Level_1_Lab_Practice
{
    internal class University_Student_Management
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student("Ankit Gupta", 101, "A");
            Student s2 = new Student("Riya Verma", 102, "B");
            Student.DisplayTotalStudents();
            DisplayStudentInfo(s1);
            DisplayStudentInfo(s2);
        }
        public static void DisplayStudentInfo(object obj)
        {
            if (obj is Student s)
            {
                s.Display();
            }
        }
    }
    public class Student
    {
        public static string universityName = "Delhi University";
        public static int totalStudents;
        private string name;
        public readonly int rollNumber;
        private string grade;
        public Student (string name, int rollNumber, string grade)
        {
            this.name = name;
            this.rollNumber = rollNumber;
            this.grade = grade;
            totalStudents++;
        }
        public void Display()
        {
            Console.WriteLine($"{name} with roll number {rollNumber} has grade {grade} at {universityName}");
        }
        public static void DisplayTotalStudents()
        {
            Console.WriteLine($"Total students enrolled are {totalStudents}");
        }
    }
}
