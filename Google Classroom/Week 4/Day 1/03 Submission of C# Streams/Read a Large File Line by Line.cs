using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google_Classroom.Week_4.Day_1._03_Submission_of_C__Streams
{
    internal class Read_a_Large_File_Line_by_Line
    {
        public static void Main(string[] args)
        {
            string path = "server_log.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("INFO: Server started at 10:00 AM");
                    sw.WriteLine("DEBUG: Checking network status");
                    sw.WriteLine("ERROR: Failed to connect database at 10:05 AM");
                    sw.WriteLine("INFO: Retry connection");
                    sw.WriteLine("error: Timeout reached on port 8080");
                    sw.WriteLine("INFO: Worker process completed");
                }
            }
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                        Console.WriteLine(line);
                }
            }
        }
    }
}
