using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Google_Classroom.Week_1.Day_6._01_Java_Class_and_Object_Level_1_Lab_Practice
{
    internal class Display_Employee_Details
    {
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee("John", 3, 80000);
            emp1.Display();
        }
    }
    class Employee
    {
        private string name;
        private int id;
        private int salary;
        public Employee (string name, int id, int salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }
        public void Display()
        {
            Console.WriteLine($"Your name is {name} with id {id} and your salary is {salary}");
        }
    }
}
