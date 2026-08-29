using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google_Classroom.Week_5.Day_1._01_Submission_of_CSV_Data_Handling
{
    internal class Search_for_a_Record_in_CSV
    {
        public static void Main(string[] args)
        {
            string path = "employees.csv";
            if (!File.Exists(path))
            {
                File.WriteAllLines(path, new string[] {
                    "ID,Name,Department,Salary",
                    "1,Amit,IT,60000",
                    "2,Pooja,HR,45000",
                    "3,Rahul,IT,70000"
                });
            }
            string searchName = "Rahul";
            using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] cols = line.Split(',');
                    if (cols[1].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Department: {cols[2]}, Salary: {cols[3]}");
                        break;
                    }
                }
            }
        }
    }
}
