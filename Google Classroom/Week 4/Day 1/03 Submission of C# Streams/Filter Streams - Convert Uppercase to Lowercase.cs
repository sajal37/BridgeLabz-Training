using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google_Classroom.Week_4.Day_1._03_Submission_of_C__Streams
{
    internal class Filter_Streams___Convert_Uppercase_to_Lowercase
    {
        public static void Main(string[] args)
        {
            string src = "upper_text.txt";
            string dest = "lower_text.txt";
            if (!File.Exists(src))
                File.WriteAllText(src, "HELLO BRIDGELABZ C# STREAMS TUTORIAL");
            try
            {
                using (FileStream fsIn = new FileStream(src, FileMode.Open, FileAccess.Read))
                using (BufferedStream bsIn = new BufferedStream(fsIn))
                using (StreamReader sr = new StreamReader(bsIn, Encoding.UTF8))
                using (FileStream fsOut = new FileStream(dest, FileMode.Create, FileAccess.Write))
                using (BufferedStream bsOut = new BufferedStream(fsOut))
                using (StreamWriter sw = new StreamWriter(bsOut, Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                        sw.WriteLine(line.ToLower());
                }
                string result = File.ReadAllText(dest);
                Console.Write($"Converted: {result.Trim()}");
            }
            catch (Exception ex)
            {
                Console.Write($"Error: {ex.Message}");
            }
        }
    }
}
