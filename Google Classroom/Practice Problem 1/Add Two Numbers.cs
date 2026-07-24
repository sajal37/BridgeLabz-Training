using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_1
{
    internal class Add_Two_Numbers
    {
        public void Demo()
        {
            Console.Write("Enter 2 numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
