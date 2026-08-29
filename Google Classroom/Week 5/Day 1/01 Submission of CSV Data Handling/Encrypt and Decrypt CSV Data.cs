using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google_Classroom.Week_5.Day_1._01_Submission_of_CSV_Data_Handling
{
    internal class Encrypt_and_Decrypt_CSV_Data
    {
        public static void Main(string[] args)
        {
            string path = "encrypted_employees.csv";
            string[] records = {
                "ID,Name,Email,Salary",
                "1,Amit,amit@example.com,75000",
                "2,Pooja,pooja@example.com,82000"
            };
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(records[0]);
                for (int i = 1; i < records.Length; i++)
                {
                    string[] cols = records[i].Split(',');
                    cols[2] = Encrypt(cols[2]);
                    cols[3] = Encrypt(cols[3]);
                    sw.WriteLine(string.Join(",", cols));
                }
            }
            Console.WriteLine("Decrypted Records:");
            using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] cols = line.Split(',');
                    string email = Decrypt(cols[2]);
                    string salary = Decrypt(cols[3]);
                    Console.WriteLine($"ID: {cols[0]}, Name: {cols[1]}, Email: {email}, Salary: {salary}");
                }
            }
        }
        static string Encrypt(string plainText)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(bytes);
        }
        static string Decrypt(string cipherText)
        {
            byte[] bytes = Convert.FromBase64String(cipherText);
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
