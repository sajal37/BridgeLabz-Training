using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_1.Sajal_Gupta___Submission_of_Inheritance
{
    internal class School_System_with_Different_Roles
    {
        public void Demo()
        {
            Teacher t = new Teacher("Mr. Smith", 45, "Mathematics");
            Student s = new Student("Emma Johnson", 16, "Grade 10");
            Staff st = new Staff("John Doe", 38, "Librarian");

            t.DisplayRole();
            s.DisplayRole();
            st.DisplayRole();
        }
    }

    class Person
    {
        protected string Name;
        protected int Age;

        public Person (string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public virtual void DisplayRole()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Teacher : Person
    {
        private string Subject;

        public Teacher (string name, int age, string subject) : base(name, age)
        {
            this.Subject = subject;
        }

        public override void DisplayRole()
        {
            Console.WriteLine($"Teacher - Name: {Name}, Age: {Age}, Subject: {Subject}");
        }
    }

    class Student : Person
    {
        private string Grade;

        public Student (string name, int age, string grade) : base(name, age)
        {
            this.Grade = grade;
        }

        public override void DisplayRole()
        {
            Console.WriteLine($"Student - Name: {Name}, Age: {Age}, Grade: {Grade}");
        }
    }

    class Staff : Person
    {
        private string Role;

        public Staff (string name, int age, string role) : base(name, age)
        {
            this.Role = role;
        }

        public override void DisplayRole()
        {
            Console.WriteLine($"Staff - Name: {Name}, Age: {Age}, Role: {Role}");
        }
    }
}
