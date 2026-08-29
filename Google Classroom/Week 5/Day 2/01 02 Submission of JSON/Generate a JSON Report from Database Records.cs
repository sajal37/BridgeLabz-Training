using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Google_Classroom.Week_5.Day_2._01_02_Submission_of_JSON
{
    internal class Generate_a_JSON_Report_from_Database_Records
    {
        public static void Main(string[] args)
        {
            List<DbEmployee> employees = new List<DbEmployee>() {
                new DbEmployee(101, "Sajal", "Tech", 85000),
                new DbEmployee(102, "Megha", "Operations", 62000),
                new DbEmployee(103, "Deepak", "HR", 54000)
            };
            string reportFile = "db_report.json";
            string json = JsonConvert.SerializeObject(employees, Formatting.Indented);
            File.WriteAllText(reportFile, json);
            Console.WriteLine($"Generated JSON report with {employees.Count} records");
        }
    }
    class DbEmployee
    {
        public int id;
        public string name;
        public string department;
        public double salary;
        public DbEmployee (int id, string name, string department, double salary)
        {
            this.id = id;
            this.name = name;
            this.department = department;
            this.salary = salary;
        }
    }
}
