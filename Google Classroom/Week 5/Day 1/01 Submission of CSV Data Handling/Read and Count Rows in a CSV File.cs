using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google_Classroom.Week_5.Day_1._01_Submission_of_CSV_Data_Handling
{
    internal class Read_and_Count_Rows_in_a_CSV_File
    {
        public static void Main(string[] args)
        {
            string path = "data.csv";
            if (!File.Exists(path))
            {
                File.WriteAllLines(path, new string[] {
                    "ID,Item,Price",
                    "1,Keyboard,1200",
                    "2,Mouse,500",
                    "3,Monitor,8000",
                    "4,Headphones,1500"
                });
            }
            int rowCount = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine();
                while (sr.ReadLine() != null)
                    rowCount++;
            }
            Console.Write($"Total Records: {rowCount}");
        }
    }
}
