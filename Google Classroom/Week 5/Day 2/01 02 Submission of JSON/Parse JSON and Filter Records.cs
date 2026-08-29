using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using Newtonsoft.Json.Linq;

namespace Google_Classroom.Week_5.Day_2._01_02_Submission_of_JSON
{
    internal class Parse_JSON_and_Filter_Records
    {
        public static void Main(string[] args)
        {
            string json = "[{\"name\": \"John\", \"age\": 22}, {\"name\": \"Alice\", \"age\": 28}, {\"name\": \"Bob\", \"age\": 31}, {\"name\": \"David\", \"age\": 24}]";
            JArray arr = JArray.Parse(json);
            foreach (JObject item in arr)
            {
                int age = (int)item["age"];
                if (age > 25)
                    Console.WriteLine($"Name: {item["name"]}, Age: {age}");
            }
        }
    }
}
