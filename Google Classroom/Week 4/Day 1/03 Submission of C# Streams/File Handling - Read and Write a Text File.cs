using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google_Classroom.Week_4.Day_1._03_Submission_of_C__Streams
{
    internal class File_Handling___Read_and_Write_a_Text_File
    {
        public static void Main(string[] args)
        {
            string src = "source.txt";
            string dest = "destination.txt";
            if (!File.Exists(src))
            {
                Console.WriteLine("Source file does not exist");
                File.WriteAllText(src, "Hello BridgeLabz FileStream");
            }
            try
            {
                using (FileStream fsRead = new FileStream(src, FileMode.Open, FileAccess.Read))
                using (FileStream fsWrite = new FileStream(dest, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead;
                    while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                        fsWrite.Write(buffer, 0, bytesRead);
                }
                string text = File.ReadAllText(dest);
                Console.Write($"Copied: {text}");
            }
            catch (IOException ex)
            {
                Console.Write($"IO Error: {ex.Message}");
            }
        }
    }
}
