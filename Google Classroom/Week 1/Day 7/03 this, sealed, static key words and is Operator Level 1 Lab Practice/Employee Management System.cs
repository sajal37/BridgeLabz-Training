using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_7._03_this__sealed__static_key_words_and_is_Operator_Level_1_Lab_Practice
{
    internal class Employee_Management_System
    {
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee("Amit Kumar", 501, "Software Engineer");
            Employee emp2 = new Employee("Neha Sharma", 502, "Project Manager");
            DisplayEmployeeInfo(emp1);
            DisplayEmployeeInfo(emp2);
            Employee.DisplayTotalEmployees();
        }
        public static void DisplayEmployeeInfo(object obj)
        {
            if (obj is Employee emp)
            {
                emp.Display();
            }
        }
    }
    class Employee
    {
        public static string companyName = "TechCorp";
        public static int totalEmployees;
        private string name;
        public readonly int id;
        private string designation;
        public Employee (string name, int id, string designation)
        {
            this.name = name;
            this.id = id;
            this.designation = designation;
            totalEmployees++;
        }
        public void Display()
        {
            Console.WriteLine($"{name} with id {id} works as {designation} at {companyName}");
        }
        public static void DisplayTotalEmployees()
        {
            Console.WriteLine($"Total employees are {totalEmployees}");
        }
    }
}
