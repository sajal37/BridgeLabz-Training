using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Student_GPA
{
    public class ValidateSubject
    {
        public void Validate()
        {
            List<string> sub = new List<string> { "MATH", "SCI", "ENG", "HIST", "GEO" };
            string[] lines = File.ReadAllLines("students.csv");
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                string code = parts[2];
                if (!sub.Contains(code))
                {
                    throw new UnknownSubjectException(code);
                }
            }
        }
    }
}