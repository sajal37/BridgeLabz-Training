using System;
using System.Collections.Generic;
using System.Text;

namespace Student_GPA
{
    public class GenerateTxt
    {
        public static void Main(string[] args)
        {
            string[] ids = { "S1", "S2", "S3" };
            string[] names = { "Aarav", "Diya", "Ishaan" };
            int[] gpas = { 2, 1, 3 };
            FileStream fs = new FileStream("rank_report.txt", FileMode.Create);
            BufferedStream bs = new BufferedStream(fs);
            using (StreamWriter sw = new StreamWriter(bs))
            {
                for (int i = 0; i < ids.Length; i++)
                {
                    sw.WriteLine($"{ids[i]} {names[i]} {gpas[i]}");
                }
            }
        }
    }
}
