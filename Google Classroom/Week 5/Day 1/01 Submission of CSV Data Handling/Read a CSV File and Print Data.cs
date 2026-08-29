using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google_Classroom.Week_5.Day_1._01_Submission_of_CSV_Data_Handling
{
    internal class Read_a_CSV_File_and_Print_Data
    {
        public static void Main(string[] args)
        {
            string path = "students.csv";
            if (!File.Exists(path))
            {
                File.WriteAllLines(path, new string[] {
                    "ID,Name,Age,Marks",
                    "101,John,20,85",
                    "102,Alice,21,90",
                    "103,Bob,19,75"
                });
            }
            using (StreamReader sr = new StreamReader(path))
            {
                string header = sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    Console.WriteLine($"ID: {parts[0]}, Name: {parts[1]}, Age: {parts[2]}, Marks: {parts[3]}");
                }
            }
        }
    }
}
