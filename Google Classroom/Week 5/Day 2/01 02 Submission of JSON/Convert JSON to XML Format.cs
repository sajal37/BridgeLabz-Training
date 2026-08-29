using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Newtonsoft.Json;

namespace Google_Classroom.Week_5.Day_2._01_02_Submission_of_JSON
{
    internal class Convert_JSON_to_XML_Format
    {
        public static void Main(string[] args)
        {
            string json = "{\"student\": {\"id\": \"101\", \"name\": \"Pooja\", \"department\": \"Computer Science\"}}";
            XmlDocument doc = JsonConvert.DeserializeXmlNode(json);
            Console.WriteLine(doc.OuterXml);
        }
    }
}
