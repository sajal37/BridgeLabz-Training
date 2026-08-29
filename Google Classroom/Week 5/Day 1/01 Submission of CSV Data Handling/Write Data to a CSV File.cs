using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Text;

namespace Google_Classroom.Week_5.Day_1._01_Submission_of_CSV_Data_Handling
{
    internal class Write_Data_to_a_CSV_File
    {
        public static void Main(string[] args)
        {
            string path = "employees.csv";
            string[] records = {
                "ID,Name,Department,Salary",
                "1,Amit,IT,60000",
                "2,Pooja,HR,45000",
                "3,Rahul,IT,70000",
                "4,Sneha,Finance,55000",
                "5,Vikas,Marketing,50000"
            };
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (string rec in records)
                    sw.WriteLine(rec);
            }
            Console.WriteLine($"Written {records.Length - 1} records to {path}");
        }
    }
}
