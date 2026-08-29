using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google_Classroom.Week_5.Day_1._01_Submission_of_CSV_Data_Handling
{
    internal class Generate_a_CSV_Report_from_Database
    {
        public static void Main(string[] args)
        {
            List<EmployeeRecord> dbRecords = new List<EmployeeRecord>() {
                new EmployeeRecord(101, "Suresh", "Engineering", 75000),
                new EmployeeRecord(102, "Meena", "Marketing", 52000),
                new EmployeeRecord(103, "Raj", "Sales", 48000),
                new EmployeeRecord(104, "Kavita", "HR", 58000)
            };
            string reportPath = "employee_db_report.csv";
            using (StreamWriter sw = new StreamWriter(reportPath))
            {
                sw.WriteLine("Employee ID,Name,Department,Salary");
                foreach (EmployeeRecord emp in dbRecords)
                    sw.WriteLine(emp.ToCsvRow());
            }
            Console.Write($"Generated report at {reportPath} with {dbRecords.Count} records");
        }
    }
    class EmployeeRecord
    {
        private int empId;
        private string name;
        private string department;
        private double salary;
        public EmployeeRecord (int empId, string name, string department, double salary)
        {
            this.empId = empId;
            this.name = name;
            this.department = department;
            this.salary = salary;
        }
        public string ToCsvRow()
        {
            return $"{empId},{name},{department},{salary}";
        }
    }
}
