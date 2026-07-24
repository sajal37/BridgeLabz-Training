using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_3
{
    internal class Swap_Two_Numbers
    {
        public void Demo()
        {
            Console.Write("Enter number1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine($"Swapped: {number1}, {number2}");
        }
    }
}
