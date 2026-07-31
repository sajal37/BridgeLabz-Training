using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Google_Classroom.Week_1.Day_7._02_Java_Constructors__Instance_vs._Class_Variables__Access_Modifiers_Level_1_Lab_Practice
{
    internal class Employee_Records
    {
        public static void Main(string[] args)
        {
            Manager mgr = new Manager(501, "IT", 95000);
            mgr.Display();
            mgr.SetSalary(105000);
            Console.WriteLine($"Updated salary is {mgr.GetSalary()}");
        }
    }
    class EmployeeBase
    {
        public int employeeID;
        protected string department;
        private double salary;
        public EmployeeBase(int employeeID, string department, double salary)
        {
            this.employeeID = employeeID;
            this.department = department;
            this.salary = salary;
        }
        public double GetSalary()
        {
            return salary;
        }
        public void SetSalary(double salary)
        {
            this.salary = salary;
        }
    }
    class Manager : EmployeeBase
    {
        public Manager (int employeeID, string department, double salary) : base(employeeID, department, salary)
        {
        }
        public void Display()
        {
            Console.WriteLine($"Employee {employeeID} works in {department} with salary {GetSalary()}");
        }
    }
}
