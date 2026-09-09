using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace Student_GPA
{
    public class GenerateJson
    {
        public void report()
        {
            string[] ids = { "S1", "S2", "S3" };
            string[] names = { "Aarav", "Diya", "Ishaan" };
            int[] gpas = { 2, 1, 3 }; 
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<ids.Length; i++)
            {
                sb.AppendLine($"{ids[i]} {names[i]} {gpas[i]}");
            }
            File.WriteAllText("gpa_report.json", sb.ToString());
        }
    }
}
