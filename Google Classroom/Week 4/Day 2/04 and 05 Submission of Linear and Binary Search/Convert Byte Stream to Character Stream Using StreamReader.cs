using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Google_Classroom.Week_4.Day_2._04_and_05_Submission_of_Linear_and_Binary_Search
{
    internal class Convert_Byte_Stream_to_Character_Stream_Using_StreamReader
    {
        public static void Main(string[] args)
        {
            string path = "binary_data.bin";
            byte[] bytes = Encoding.UTF8.GetBytes("Byte stream successfully converted to character stream!");
            File.WriteAllBytes(path, bytes);
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
            {
                string content = sr.ReadToEnd();
                Console.Write(content);
            }
        }
    }
}
