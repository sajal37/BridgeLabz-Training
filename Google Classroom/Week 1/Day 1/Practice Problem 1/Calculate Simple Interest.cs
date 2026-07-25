using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_1
{
    internal class Calculate_Simple_Interest
    {
        public void Demo()
        {
            Console.WriteLine("Enter principal, rate and time: ");
            int Principal= Convert.ToInt32(Console.ReadLine());
            int Rate= Convert.ToInt32(Console.ReadLine());
            int Time= Convert.ToInt32(Console.ReadLine());
            int Simple_Interest = (Principal * Rate * Time) / 100;
            Console.Write($"Simple Interest: {Simple_Interest}");
        }
    }
}
