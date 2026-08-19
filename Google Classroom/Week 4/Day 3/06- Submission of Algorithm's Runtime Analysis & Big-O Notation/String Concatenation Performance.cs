using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Google_Classroom.Week_4.Day_3._06__Submission_of_Algorithm_s_Runtime_Analysis___Big_O_Notation
{
    internal class String_Concatenation_Performance
    {
        public static void Main(string[] args)
        {
            int[] counts = { 1000, 10000, 50000 };
            foreach (int count in counts)
            {
                Stopwatch sw1 = Stopwatch.StartNew();
                string str = "";
                for (int i = 0; i < count; i++) str += "x";
                sw1.Stop();
                long strTime = sw1.ElapsedMilliseconds;
                Stopwatch sw2 = Stopwatch.StartNew();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < count; i++) sb.Append("x");
                sw2.Stop();
                long sbTime = sw2.ElapsedMilliseconds;
                Console.WriteLine($"Count: {count} | String (+): {strTime} ms | StringBuilder: {sbTime} ms");
            }
        }
    }
}
