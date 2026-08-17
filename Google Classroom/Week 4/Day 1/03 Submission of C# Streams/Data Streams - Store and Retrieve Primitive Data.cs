using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Google_Classroom.Week_4.Day_1._03_Submission_of_C__Streams
{
    internal class Data_Streams___Store_and_Retrieve_Primitive_Data
    {
        public static void Main(string[] args)
        {
            string fileName = "student_data.bin";
            int roll = 101;
            string name = "Sajal Gupta";
            double gpa = 8.75;
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                bw.Write(roll);
                bw.Write(name);
                bw.Write(gpa);
            }
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            using (BinaryReader br = new BinaryReader(fs))
            {
                int rRoll = br.ReadInt32();
                string rName = br.ReadString();
                double rGpa = br.ReadDouble();
                Console.WriteLine($"Roll No: {rRoll}");
                Console.WriteLine($"Name: {rName}");
                Console.Write($"GPA: {rGpa}");
            }
        }
    }
}
