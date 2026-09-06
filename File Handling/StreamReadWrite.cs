using System;
using System.Collections.Generic;
using System.Text;

namespace File_Handling
{
    public class StreamReadWrite
    {
        public static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("students.txt"))
            {
                writer.WriteLine("Sajal");
                writer.WriteLine("Bhav");
                writer.WriteLine("Aaryan");
            }
            using (StreamReader reader = new StreamReader("students.txt"))
            {
                string data = reader.ReadToEnd();
                Console.WriteLine(data);
            }
        }
    }
}
