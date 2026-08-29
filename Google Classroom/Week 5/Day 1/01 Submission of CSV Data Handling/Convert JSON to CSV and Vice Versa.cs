using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Google_Classroom.Week_5.Day_1._01_Submission_of_CSV_Data_Handling
{
    internal class Convert_JSON_to_CSV_and_Vice_Versa
    {
        public static void Main(string[] args)
        {
            string jsonFile = "students.json";
            string csvFile = "students_converted.csv";
            List<StudentModel> list = new List<StudentModel>() {
                new StudentModel { Id = 1, Name = "Aman", Age = 20 },
                new StudentModel { Id = 2, Name = "Pooja", Age = 21 }
            };
            string jsonData = JsonSerializer.Serialize(list);
            File.WriteAllText(jsonFile, jsonData);
            ConvertJsonToCsv(jsonFile, csvFile);
            ConvertCsvToJson(csvFile, "students_back.json");
            Console.WriteLine($"Converted JSON to CSV and back successfully");
        }
        static void ConvertJsonToCsv(string jsonPath, string csvPath)
        {
            string json = File.ReadAllText(jsonPath);
            List<StudentModel> items = JsonSerializer.Deserialize<List<StudentModel>>(json);
            List<string> lines = new List<string>();
            lines.Add("Id,Name,Age");
            foreach (StudentModel s in items)
                lines.Add($"{s.Id},{s.Name},{s.Age}");
            File.WriteAllLines(csvPath, lines);
        }
        static void ConvertCsvToJson(string csvPath, string outJsonPath)
        {
            string[] lines = File.ReadAllLines(csvPath);
            List<StudentModel> items = new List<StudentModel>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                items.Add(new StudentModel { Id = Convert.ToInt32(parts[0]), Name = parts[1], Age = Convert.ToInt32(parts[2]) });
            }
            string json = JsonSerializer.Serialize(items);
            File.WriteAllText(outJsonPath, json);
        }
    }
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
