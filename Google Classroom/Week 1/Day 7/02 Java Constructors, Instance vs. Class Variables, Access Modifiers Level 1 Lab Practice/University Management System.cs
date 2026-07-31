using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_7._02_Java_Constructors__Instance_vs._Class_Variables__Access_Modifiers_Level_1_Lab_Practice
{
    internal class University_Management_System
    {
        public static void Main(string[] args)
        {
            PostgraduateStudent pg1 = new PostgraduateStudent(101, "Alice", 8.5, "Computer Science");
            pg1.Display();
            pg1.SetCGPA(9.1);
            Console.WriteLine($"Updated CGPA is {pg1.GetCGPA()}");
        }
    }
    public class Student
    {
        public int rollNumber;
        protected string name;
        private double cgpa;
        public Student(int rollNumber, string name, double cgpa)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.cgpa = cgpa;
        }
        public double GetCGPA()
        {
            return cgpa;
        }
        public void SetCGPA(double cgpa)
        {
            this.cgpa = cgpa;
        }
    }
    public class PostgraduateStudent : Student
    {
        private string specialization;
        public PostgraduateStudent (int rollNumber, string name, double cgpa, string specialization) : base(rollNumber, name, cgpa)
        {
            this.specialization = specialization;
        }
        public void Display()
        {
            Console.WriteLine($"Roll number {rollNumber} is {name} with CGPA {GetCGPA()} specializing in {specialization}");
        }
    }
}
