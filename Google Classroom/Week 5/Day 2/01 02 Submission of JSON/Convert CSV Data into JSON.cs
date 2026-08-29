using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Google_Classroom.Week_5.Day_2._01_02_Submission_of_JSON
{
    internal class Convert_CSV_Data_into_JSON
    {
        public static void Main(string[] args)
        {
            string csvPath = "sample_records.csv";
            if (!File.Exists(csvPath))
            {
                File.WriteAllLines(csvPath, new string[] {
                    "id,name,role",
                    "1,Aman,Developer",
                    "2,Riya,Tester",
                    "3,Karan,Manager"
                });
            }
            string[] lines = File.ReadAllLines(csvPath);
            string[] headers = lines[0].Split(',');
            JArray arr = new JArray();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                JObject obj = new JObject();
                for (int j = 0; j < headers.Length; j++)
                    obj[headers[j].Trim()] = parts[j].Trim();
                arr.Add(obj);
            }
            string json = arr.ToString(Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
