using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Student_GPA
{
    public class StreamRecords
    {
        public void Stream()
        {
            using(var str=new StreamReader("students.csv"))
            {
                string header = str.ReadLine();
                while(!str.EndOfStream)
                {
                    string line = str.ReadLine();
                    string[] parts = line.Split(',');
                    string id = parts[0];
                    string name = parts[1];
                    string subject = parts[2];
                    int marks = Convert.ToInt32(parts[3]);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        byte[] bytes = Encoding.UTF8.GetBytes(marks + "\n");
                        ms.Write(bytes, 0, bytes.Length);
                    }
                    Console.WriteLine($"{id} {name} {subject} {marks}");
                }
            }
        }
    }
}

