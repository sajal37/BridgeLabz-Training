using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google_Classroom.Week_4.Day_1._03_Submission_of_C__Streams
{
    internal class Read_User_Input_from_Console
    {
        public static void Main(string[] args)
        {
            try
            {
                StreamReader reader = new StreamReader(Console.OpenStandardInput());
                Console.Write("Enter your name: ");
                string name = reader.ReadLine();
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(reader.ReadLine());
                Console.Write("Enter your favorite programming language: ");
                string lang = reader.ReadLine();
                string filePath = "user_info.txt";
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine($"Name: {name}");
                    writer.WriteLine($"Age: {age}");
                    writer.WriteLine($"Language: {lang}");
                }
                Console.WriteLine("Saved to file:");
                Console.Write(File.ReadAllText(filePath));
            }
            catch (Exception ex)
            {
                Console.Write($"Error: {ex.Message}");
            }
        }
    }
}
