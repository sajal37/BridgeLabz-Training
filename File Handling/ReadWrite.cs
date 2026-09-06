using System;
using System.Collections.Generic;
using System.Text;

namespace File_Handling
{
    public class ReadWrite
    {
        public static void Main(string[] args)
        {
            File.WriteAllText("data.txt", "ABC");
            string data = File.ReadAllText("data.txt");
            Console.WriteLine(data);
        }
    }
}
