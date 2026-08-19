using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Google_Classroom.Week_4.Day_2._04_and_05_Submission_of_Linear_and_Binary_Search
{
    internal class Compare_StringBuilder_Performance
    {
        public static void Main(string[] args)
        {
            int n = 50000;
            Stopwatch sw1 = Stopwatch.StartNew();
            string str = "";
            for (int i = 0; i < n; i++) str += "a";
            sw1.Stop();
            long stringTime = sw1.ElapsedMilliseconds;
            Console.WriteLine($"String Time: {stringTime} ms");
            Stopwatch sw2 = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++) sb.Append("a");
            sw2.Stop();
            long sbTime = sw2.ElapsedMilliseconds;
            Console.Write($"StringBuilder Time: {sbTime} ms");
        }
    }
}
