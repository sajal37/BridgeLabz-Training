using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Actual_Work
{
    public class FileProcessor
    {
        public void WriteToFile(string filename, string content)
        {
            File.WriteAllText(filename, content);
        }

        public string ReadFromFile(string filename)
        {
            if (!File.Exists(filename))
                throw new IOException("File not found");
            string Content = File.ReadAllText(filename);
            return Content;
        }

        public bool FileExists(string filename)
        {
            bool Exists = File.Exists(filename);
            return Exists;
        }
    }
}
