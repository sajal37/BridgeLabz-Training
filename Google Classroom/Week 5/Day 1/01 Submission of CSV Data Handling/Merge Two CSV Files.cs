using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google_Classroom.Week_5.Day_1._01_Submission_of_CSV_Data_Handling
{
    internal class Merge_Two_CSV_Files
    {
        public static void Main(string[] args)
        {
            string f1 = "students1.csv";
            string f2 = "students2.csv";
            string merged = "students_merged.csv";
            if (!File.Exists(f1))
            {
                File.WriteAllLines(f1, new string[] {
                    "ID,Name,Age",
                    "1,Aman,20",
                    "2,Riya,19",
                    "3,Karan,21"
                });
            }
            if (!File.Exists(f2))
            {
                File.WriteAllLines(f2, new string[] {
                    "ID,Marks,Grade",
                    "1,85,A",
                    "2,92,A+",
                    "3,78,B"
                });
            }
            Dictionary<string, string> map = new Dictionary<string, string>();
            using (StreamReader sr = new StreamReader(f2))
            {
                sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    map[parts[0]] = parts[1] + "," + parts[2];
                }
            }
            List<string> output = new List<string>();
            output.Add("ID,Name,Age,Marks,Grade");
            using (StreamReader sr = new StreamReader(f1))
            {
                sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string extra = map.ContainsKey(parts[0]) ? map[parts[0]] : ",";
                    output.Add($"{parts[0]},{parts[1]},{parts[2]},{extra}");
                }
            }
            File.WriteAllLines(merged, output);
            Console.WriteLine($"Merged {output.Count - 1} records into {merged}");
        }
    }
}
