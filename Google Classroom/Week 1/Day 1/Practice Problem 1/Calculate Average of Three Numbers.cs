using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_1
{
    internal class Calculate_Average_of_Three_Numbers
    {
        public void Demo()
        {
            Console.WriteLine("Enter three numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            double average = (num1 + num2 + num3) / 3;
            Console.Write($"Average: {average}");
        }
    }
}
