using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google_Classroom.Week_5.Day_1._01_Submission_of_CSV_Data_Handling
{
    internal class Detect_Duplicates_in_a_CSV_File
    {
        public static void Main(string[] args)
        {
            string path = "entries_with_duplicates.csv";
            if (!File.Exists(path))
            {
                File.WriteAllLines(path, new string[] {
                    "ID,Name,Department",
                    "101,Amit,IT",
                    "102,Pooja,HR",
                    "103,Rahul,Finance",
                    "101,Amit Kumar,IT",
                    "104,Sneha,Marketing",
                    "102,Pooja S,HR"
                });
            }
            HashSet<string> set1 = new HashSet<string>();
            List<string> duplicates = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string id = parts[0].Trim();
                    if (set1.Contains(id))
                        duplicates.Add(line);
                    else
                        set1.Add(id);
                }
            }
            foreach (string d in duplicates)
                Console.WriteLine($"Duplicate: {d}");
        }
    }
}
