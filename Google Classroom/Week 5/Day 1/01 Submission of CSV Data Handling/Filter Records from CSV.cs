using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google_Classroom.Week_5.Day_1._01_Submission_of_CSV_Data_Handling
{
    internal class Filter_Records_from_CSV
    {
        public static void Main(string[] args)
        {
            string path = "students_marks.csv";
            if (!File.Exists(path))
            {
                File.WriteAllLines(path, new string[] {
                    "ID,Name,Age,Marks",
                    "1,Aman,20,85",
                    "2,Riya,19,78",
                    "3,Karan,21,92",
                    "4,Divya,20,65",
                    "5,Tarun,22,88"
                });
            }
            using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] cols = line.Split(',');
                    int marks = Convert.ToInt32(cols[3]);
                    if (marks > 80)
                        Console.WriteLine($"ID: {cols[0]}, Name: {cols[1]}, Marks: {marks}");
                }
            }
        }
    }
}
