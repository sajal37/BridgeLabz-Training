using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Google_Classroom.Week_5.Day_2._01_02_Submission_of_JSON
{
    internal class Validate_JSON_Structure_Using_Schema
    {
        public static void Main(string[] args)
        {
            string json = "{\"id\": 101, \"name\": \"Pooja\", \"age\": 24}";
            JObject obj = JObject.Parse(json);
            bool isValid = obj.ContainsKey("id") && obj.ContainsKey("name") && obj.ContainsKey("age") && obj["age"].Type == JTokenType.Integer;
            if (isValid) Console.WriteLine("Valid JSON Structure");
            else Console.WriteLine("Invalid JSON Structure");
        }
    }
}
