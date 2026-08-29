using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Google_Classroom.Week_5.Day_2._01_02_Submission_of_JSON
{
    internal class Merge_Two_JSON_Files_into_a_Single_JSON_Object
    {
        public static void Main(string[] args)
        {
            string file1 = "personal.json";
            string file2 = "professional.json";
            string mergedFile = "merged_profile.json";
            if (!File.Exists(file1))
                File.WriteAllText(file1, "{\"id\": 101, \"name\": \"Vikram\", \"age\": 25}");
            if (!File.Exists(file2))
                File.WriteAllText(file2, "{\"role\": \"Developer\", \"company\": \"BridgeLabz\", \"experience\": 3}");
            JObject obj1 = JObject.Parse(File.ReadAllText(file1));
            JObject obj2 = JObject.Parse(File.ReadAllText(file2));
            obj1.Merge(obj2);
            File.WriteAllText(mergedFile, obj1.ToString());
            Console.WriteLine(obj1.ToString());
        }
    }
}
