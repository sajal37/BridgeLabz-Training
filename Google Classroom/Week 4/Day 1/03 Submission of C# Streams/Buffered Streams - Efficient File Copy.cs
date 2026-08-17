using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Text;

namespace Google_Classroom.Week_4.Day_1._03_Submission_of_C__Streams
{
    internal class Buffered_Streams___Efficient_File_Copy
    {
        public static void Main(string[] args)
        {
            string src = "large_sample.dat";
            string dest1 = "unbuffered_copy.dat";
            string dest2 = "buffered_copy.dat";
            byte[] data = new byte[1024 * 1024 * 5];
            new Random().NextBytes(data);
            File.WriteAllBytes(src, data);
            Stopwatch sw1 = Stopwatch.StartNew();
            using (FileStream fsIn = new FileStream(src, FileMode.Open))
            using (FileStream fsOut = new FileStream(dest1, FileMode.Create))
            {
                byte[] buf = new byte[4096];
                int read;
                while ((read = fsIn.Read(buf, 0, buf.Length)) > 0)
                    fsOut.Write(buf, 0, read);
            }
            sw1.Stop();
            long unbufferedTime = sw1.ElapsedMilliseconds;
            Console.WriteLine($"Unbuffered Time: {unbufferedTime} ms");
            Stopwatch sw2 = Stopwatch.StartNew();
            using (FileStream fsIn = new FileStream(src, FileMode.Open))
            using (BufferedStream bsIn = new BufferedStream(fsIn))
            using (FileStream fsOut = new FileStream(dest2, FileMode.Create))
            using (BufferedStream bsOut = new BufferedStream(fsOut))
            {
                byte[] buf = new byte[4096];
                int read;
                while ((read = bsIn.Read(buf, 0, buf.Length)) > 0)
                    bsOut.Write(buf, 0, read);
            }
            sw2.Stop();
            long bufferedTime = sw2.ElapsedMilliseconds;
            Console.Write($"Buffered Time: {bufferedTime} ms");
        }
    }
}
