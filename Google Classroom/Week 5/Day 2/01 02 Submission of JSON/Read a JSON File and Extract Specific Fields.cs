using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Google_Classroom.Week_5.Day_2._01_02_Submission_of_JSON
{
    internal class Read_a_JSON_File_and_Extract_Specific_Fields
    {
        public static void Main(string[] args)
        {
            string path = "user_data.json";
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "{\"id\": 1, \"name\": \"Suresh\", \"email\": \"suresh@example.com\", \"city\": \"Pune\", \"salary\": 65000}");
            }
            string json = File.ReadAllText(path);
            JObject obj = JObject.Parse(json);
            string name = (string)obj["name"];
            string email = (string)obj["email"];
            Console.WriteLine($"Name: {name}, Email: {email}");
        }
    }
}
