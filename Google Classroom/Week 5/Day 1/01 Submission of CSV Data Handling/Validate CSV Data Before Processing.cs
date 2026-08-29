using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Google_Classroom.Week_5.Day_1._01_Submission_of_CSV_Data_Handling
{
    internal class Validate_CSV_Data_Before_Processing
    {
        public static void Main(string[] args)
        {
            string path = "contacts.csv";
            if (!File.Exists(path))
            {
                File.WriteAllLines(path, new string[] {
                    "ID,Name,Email,Phone",
                    "1,Amit,amit@example.com,9876543210",
                    "2,Pooja,invalid-email,9876543210",
                    "3,Rahul,rahul@mail.com,12345",
                    "4,Sneha,sneha@work.org,9123456780"
                });
            }
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string phonePattern = @"^\d{10}$";
            using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] cols = line.Split(',');
                    bool validEmail = Regex.IsMatch(cols[2].Trim(), emailPattern);
                    bool validPhone = Regex.IsMatch(cols[3].Trim(), phonePattern);
                    if (!validEmail)
                        Console.WriteLine($"Invalid email for {cols[1]}: {cols[2]}");
                    if (!validPhone)
                        Console.WriteLine($"Invalid phone for {cols[1]}: {cols[3]}");
                }
            }
        }
    }
}
