using System;
using System.Collections.Generic;
using System.Text;

namespace Date_and_Time.Date_and_Time
{
    internal class _1st
    {
        public static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            //Console.WriteLine($"{dt} \n{dt:g} \n{dt:G} \n{dt:d} \n{dt:D} \n{dt:f} \n{dt:F}");
            Console.WriteLine($"{dt:m} \n{dt:t} \n{dt:T} \n{dt:Y} \n{dt:yyy}");
        }
    }
}
