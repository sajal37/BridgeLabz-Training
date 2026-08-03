using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_1.Sajal_Gupta___Submission_of_Inheritance
{
    internal class Employee_Management_System
    {
        public void Demo()
        {
            Manager m = new Manager("Alice", 101, 90000, 10);
            Developer d = new Developer("Bob", 102, 75000, "C#");
            Intern i = new Intern("Charlie", 103, 30000, "6 months");

            m.DisplayDetails();
            d.DisplayDetails();
            i.DisplayDetails();
        }
    }

    class Employee
    {
        protected string Name;
        protected int Id;
        protected double Salary;

        public Employee (string name, int id, double salary)
        {
            this.Name = name;
            this.Id = id;
            this.Salary = salary;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, ID: {Id}, Salary: {Salary}");
        }
    }

    class Manager : Employee
    {
        private int TeamSize;

        public Manager (string name, int id, double salary, int teamSize) : base(name, id, salary)
        {
            this.TeamSize = teamSize;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Manager - Name: {Name}, ID: {Id}, Salary: {Salary}, Team Size: {TeamSize}");
        }
    }

    class Developer : Employee
    {
        private string ProgrammingLanguage;

        public Developer (string name, int id, double salary, string language) : base(name, id, salary)
        {
            this.ProgrammingLanguage = language;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Developer - Name: {Name}, ID: {Id}, Salary: {Salary}, Language: {ProgrammingLanguage}");
        }
    }

    class Intern : Employee
    {
        private string InternshipDuration;

        public Intern (string name, int id, double salary, string duration) : base(name, id, salary)
        {
            this.InternshipDuration = duration;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Intern - Name: {Name}, ID: {Id}, Salary: {Salary}, Duration: {InternshipDuration}");
        }
    }
}
