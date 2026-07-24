using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_3
{
    internal class Quotient_and_Remainder
    {
        public void Demo()
        {
            Console.Write("Enter number1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int quotient = num1 / num2;
            int remainder = num1 % num2;
            Console.WriteLine($"Quotient: {quotient}, Remainder: {remainder}");
        }
    }
}
