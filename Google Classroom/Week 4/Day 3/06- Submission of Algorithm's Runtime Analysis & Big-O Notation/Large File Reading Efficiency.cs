using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Google_Classroom.Week_4.Day_3._06__Submission_of_Algorithm_s_Runtime_Analysis___Big_O_Notation
{
    internal class Large_File_Reading_Efficiency
    {
        public static void Main(string[] args)
        {
            string testFile = "perf_test_file.dat";
            byte[] dummyData = new byte[1024 * 1024 * 5];
            new Random().NextBytes(dummyData);
            File.WriteAllBytes(testFile, dummyData);
            Stopwatch sw1 = Stopwatch.StartNew();
            using (StreamReader sr = new StreamReader(testFile))
            {
                while (sr.ReadLine() != null) { }
            }
            sw1.Stop();
            long srTime = sw1.ElapsedMilliseconds;
            Stopwatch sw2 = Stopwatch.StartNew();
            using (FileStream fs = new FileStream(testFile, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[8192];
                while (fs.Read(buffer, 0, buffer.Length) > 0) { }
            }
            sw2.Stop();
            long fsTime = sw2.ElapsedMilliseconds;
            Console.WriteLine($"StreamReader Time: {srTime} ms");
            Console.Write($"FileStream Time: {fsTime} ms");
        }
    }
}
