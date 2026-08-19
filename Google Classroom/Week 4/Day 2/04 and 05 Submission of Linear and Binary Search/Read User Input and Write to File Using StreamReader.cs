using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google_Classroom.Week_4.Day_2._04_and_05_Submission_of_Linear_and_Binary_Search
{
    internal class Read_User_Input_and_Write_to_File_Using_StreamReader
    {
        public static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(Console.OpenStandardInput());
            Console.Write("Enter your feedback: ");
            string input = reader.ReadLine();
            string file = "feedback.txt";
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(input);
            }
            Console.Write($"Saved: {File.ReadAllText(file).Trim()}");
        }
    }
}
