using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Google_Classroom.Week_5.Day_2._01_02_Submission_of_JSON
{
    internal class Read_a_JSON_File_and_Print_All_Keys_and_Values
    {
        public static void Main(string[] args)
        {
            string path = "config.json";
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "{\"appName\": \"TrainingPortal\", \"version\": \"2.5.0\", \"environment\": \"Development\", \"maxConnections\": 50}");
            }
            string content = File.ReadAllText(path);
            JObject obj = JObject.Parse(content);
            foreach (var prop in obj.Properties())
            {
                Console.WriteLine($"{prop.Name}: {prop.Value}");
            }
        }
    }
}
