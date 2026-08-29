using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google_Classroom.Week_5.Day_1._01_Submission_of_CSV_Data_Handling
{
    internal class Modify_a_CSV_File__Update_a_Value_
    {
        public static void Main(string[] args)
        {
            string src = "employees_input.csv";
            string dest = "employees_updated.csv";
            if (!File.Exists(src))
            {
                File.WriteAllLines(src, new string[] {
                    "ID,Name,Department,Salary",
                    "1,Amit,IT,60000",
                    "2,Pooja,HR,45000",
                    "3,Rahul,IT,70000"
                });
            }
            List<string> updatedLines = new List<string>();
            using (StreamReader sr = new StreamReader(src))
            {
                string header = sr.ReadLine();
                updatedLines.Add(header);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] cols = line.Split(',');
                    if (cols[2].Trim().Equals("IT", StringComparison.OrdinalIgnoreCase))
                    {
                        double sal = Convert.ToDouble(cols[3]);
                        sal = sal * 1.10;
                        cols[3] = sal.ToString();
                    }
                    updatedLines.Add(string.Join(",", cols));
                }
            }
            File.WriteAllLines(dest, updatedLines);
            Console.WriteLine($"Updated {updatedLines.Count - 1} records saved to {dest}");
        }
    }
}
