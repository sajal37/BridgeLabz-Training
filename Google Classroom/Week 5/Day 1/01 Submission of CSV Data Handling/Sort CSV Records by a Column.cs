using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Google_Classroom.Week_5.Day_1._01_Submission_of_CSV_Data_Handling
{
    internal class Sort_CSV_Records_by_a_Column
    {
        public static void Main(string[] args)
        {
            string path = "employees_salary.csv";
            if (!File.Exists(path))
            {
                File.WriteAllLines(path, new string[] {
                    "ID,Name,Department,Salary",
                    "1,Amit,IT,60000",
                    "2,Pooja,HR,45000",
                    "3,Rahul,IT,90000",
                    "4,Sneha,Finance,80000",
                    "5,Vikas,Marketing,50000",
                    "6,Karan,IT,95000",
                    "7,Neha,HR,72000"
                });
            }
            List<string[]> rows = new List<string[]>();
            using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                    rows.Add(line.Split(','));
            }
            rows.Sort((a, b) => Convert.ToDouble(b[3]).CompareTo(Convert.ToDouble(a[3])));
            int limit = Math.Min(5, rows.Count);
            for (int i = 0; i < limit; i++)
                Console.WriteLine($"{rows[i][1]}: {rows[i][3]}");
        }
    }
}
