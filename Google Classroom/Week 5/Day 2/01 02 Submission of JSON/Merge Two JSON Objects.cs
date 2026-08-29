using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Google_Classroom.Week_5.Day_2._01_02_Submission_of_JSON
{
    internal class Merge_Two_JSON_Objects
    {
        public static void Main(string[] args)
        {
            string json1 = "{\"name\": \"Amit\", \"age\": 22}";
            string json2 = "{\"city\": \"Mumbai\", \"department\": \"Engineering\"}";
            JObject obj1 = JObject.Parse(json1);
            JObject obj2 = JObject.Parse(json2);
            obj1.Merge(obj2, new JsonMergeSettings { MergeArrayHandling = MergeArrayHandling.Union });
            Console.WriteLine(obj1.ToString());
        }
    }
}
