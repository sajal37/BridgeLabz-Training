using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google_Classroom.Week_5.Day_1._01_Submission_of_CSV_Data_Handling
{
    internal class Convert_CSV_Data_into_Objects
    {
        public static void Main(string[] args)
        {
            string path = "student_objects.csv";
            if (!File.Exists(path))
            {
                File.WriteAllLines(path, new string[] {
                    "ID,Name,Age,Marks",
                    "1,Aman,20,85",
                    "2,Riya,19,92",
                    "3,Karan,21,78"
                });
            }
            List<Student> list1 = new List<Student>();
            using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    list1.Add(new Student(Convert.ToInt32(parts[0]), parts[1], Convert.ToInt32(parts[2]), Convert.ToDouble(parts[3])));
                }
            }
            foreach (Student s in list1)
                s.Display();
        }
    }
    class Student
    {
        private int id;
        private string name;
        private int age;
        private double marks;
        public Student (int id, string name, int age, double marks)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.marks = marks;
        }
        public void Display()
        {
            Console.WriteLine($"Student ID: {id}, Name: {name}, Age: {age}, Marks: {marks}");
        }
    }
}
