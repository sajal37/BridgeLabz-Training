using System;
using System.Collections.Generic;
using System.Text;

namespace Student_GPA
{
    public class WeightedGPA
    {
        public int Grade(int marks)
        {
            if (marks >= 90) return 10;
            if (marks >= 80) return 9;
            if (marks >= 70) return 8;
            if (marks >= 60) return 7;
            if (marks >= 50) return 6;
            if (marks >= 40) return 5;
            return 0;
        }
        public int Credits(string code)
        {
            if (code == "MATH") return 4;
            if (code == "SCI") return 4;
            if (code == "ENG") return 3;
            if (code == "HIST") return 3;
            if (code == "GEO") return 2;
            return 0;
        }
        public double GPALines(string[] lines)
        {
            int p = 0;
            int c = 0;
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                int marks = int.Parse(parts[3]);
                int credits = Credits(parts[2]);
                if (marks < 0 || marks > 100) continue;
                if (credits == 0) continue;
                p += Grade(marks) * credits;
                c += credits;
            }
            if (c == 0) return 0;
            return (double)p / c;
        }
    }
}