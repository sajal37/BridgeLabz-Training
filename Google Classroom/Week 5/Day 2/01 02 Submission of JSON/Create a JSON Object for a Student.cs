using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Google_Classroom.Week_5.Day_2._01_02_Submission_of_JSON
{
    internal class Create_a_JSON_Object_for_a_Student
    {
        public static void Main(string[] args)
        {
            JObject studentObj = new JObject();
            studentObj["name"] = "Rahul";
            studentObj["age"] = 20;
            JArray subjects = new JArray() { "Math", "Physics", "Chemistry" };
            studentObj["subjects"] = subjects;
            Console.WriteLine(studentObj.ToString());
        }
    }
}
