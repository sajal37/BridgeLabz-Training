using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Google_Classroom.Week_4.Day_1._03_Submission_of_C__Streams
{
    internal class Serialization___Save_and_Retrieve_an_Object
    {
        public static void Main(string[] args)
        {
            try
            {
                List<Employee> list = new List<Employee>();
                list.Add(new Employee(101, "Sajal", "Engineering", 75000));
                list.Add(new Employee(102, "Amit", "HR", 55000));
                list.Add(new Employee(103, "Pooja", "Marketing", 60000));
                string file = "employees.json";
                string json = JsonSerializer.Serialize(list);
                File.WriteAllText(file, json);
                string readJson = File.ReadAllText(file);
                List<Employee> retrieved = JsonSerializer.Deserialize<List<Employee>>(readJson);
                foreach (Employee emp1 in retrieved)
                    emp1.Display();
            }
            catch (Exception ex)
            {
                Console.Write($"Error: {ex.Message}");
            }
        }
    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
        public Employee() { }
        public Employee (int id, string name, string department, int salary)
        {
            this.Id = id;
            this.Name = name;
            this.Department = department;
            this.Salary = salary;
        }
        public void Display()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Dept: {Department}, Salary: {Salary}");
        }
    }
}
