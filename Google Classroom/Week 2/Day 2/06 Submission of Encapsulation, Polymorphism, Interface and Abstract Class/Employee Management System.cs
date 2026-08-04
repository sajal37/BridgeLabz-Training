using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_2._06_Submission_of_Encapsulation__Polymorphism__Interface_and_Abstract_Class
{
    internal class Employee_Management_System
    {
        public void Demo()
        {
            Employee[] employees = new Employee[3];
            employees[0] = new FullTimeEmployee(101, "Rajesh Kumar", 50000);
            employees[1] = new PartTimeEmployee(102, "Priya Sharma", 200, 80);
            employees[2] = new FullTimeEmployee(103, "Amit Singh", 60000);

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].DisplayDetails();
                Console.WriteLine($"Calculated Salary: {employees[i].CalculateSalary()}");
                Console.WriteLine();
            }
        }
    }

    interface IDepartment
    {
        void AssignDepartment(string deptName);
        string GetDepartmentDetails();
    }

    abstract class Employee : IDepartment
    {
        private int employeeId;
        private string name;
        protected double baseSalary;
        private string department;

        public Employee (int id, string name, double salary)
        {
            this.employeeId = id;
            this.name = name;
            this.baseSalary = salary;
        }

        public int EmployeeId
        {
            get { return employeeId; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double BaseSalary
        {
            get { return baseSalary; }
            set 
            { 
                if (value > 0)
                    baseSalary = value; 
            }
        }

        public abstract double CalculateSalary();

        public void DisplayDetails()
        {
            Console.WriteLine($"Employee ID: {employeeId}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Base Salary: {baseSalary}");
        }

        public void AssignDepartment(string deptName)
        {
            department = deptName;
        }

        public string GetDepartmentDetails()
        {
            return department;
        }
    }

    class FullTimeEmployee : Employee
    {
        public FullTimeEmployee (int id, string name, double salary) : base(id, name, salary)
        {
        }

        public override double CalculateSalary()
        {
            return baseSalary;
        }
    }

    class PartTimeEmployee : Employee
    {
        private double hourlyRate;
        private int hoursWorked;

        public PartTimeEmployee (int id, string name, double rate, int hours) : base(id, name, 0)
        {
            this.hourlyRate = rate;
            this.hoursWorked = hours;
        }

        public override double CalculateSalary()
        {
            return hourlyRate * hoursWorked;
        }
    }
}
