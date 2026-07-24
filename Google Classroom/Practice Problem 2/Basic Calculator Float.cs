using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_2
{
    internal class Basic_Calculator_Float
    {
        public void Demo()
        {
            Console.Write("Enter number1: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number2: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            double add = number1 + number2;
            double sub = number1 - number2;
            double mul = number1 * number2;
            double div = number1 / number2;
            Console.WriteLine($"Add: {add}, Sub: {sub}, Mul: {mul}, Div: {div}");
        }
    }
}
