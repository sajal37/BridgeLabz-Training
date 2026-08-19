using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google_Classroom.Week_4.Day_2._04_and_05_Submission_of_Linear_and_Binary_Search
{
    internal class Read_a_File_Line_by_Line_Using_StreamReader
    {
        public static void Main(string[] args)
        {
            string path = "sample_lines.txt";
            if (!File.Exists(path))
            {
                File.WriteAllLines(path, new string[] { "Line 1: Welcome to BridgeLabz", "Line 2: Learning C# Streams", "Line 3: File I/O Operations" });
            }
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    Console.WriteLine(line);
            }
        }
    }
}
