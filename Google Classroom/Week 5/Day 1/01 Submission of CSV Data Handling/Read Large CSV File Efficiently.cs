using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Text;

namespace Google_Classroom.Week_5.Day_1._01_Submission_of_CSV_Data_Handling
{
    internal class Read_Large_CSV_File_Efficiently
    {
        public static void Main(string[] args)
        {
            string path = "large_sample.csv";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("ID,Value,Status");
                    for (int i = 1; i <= 250; i++)
                        sw.WriteLine($"{i},Val_{i},Active");
                }
            }
            int total = 0;
            int batchSize = 100;
            List<string> chunk = new List<string>(batchSize);
            using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    chunk.Add(line);
                    if (chunk.Count == batchSize)
                    {
                        total += chunk.Count;
                        Console.WriteLine($"Processed chunk of {chunk.Count} records (Total so far: {total})");
                        chunk.Clear();
                    }
                }
                if (chunk.Count > 0)
                {
                    total += chunk.Count;
                    Console.WriteLine($"Processed final chunk of {chunk.Count} records (Total: {total})");
                    chunk.Clear();
                }
            }
        }
    }
}
