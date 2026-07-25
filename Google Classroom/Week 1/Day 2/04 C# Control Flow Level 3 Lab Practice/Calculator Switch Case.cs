using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._04_C__Control_Flow_Level_3_Lab_Practice
{
    internal class Calculator_Switch_Case
    {
        public void Demo()
        {
            double first = Convert.ToDouble(Console.ReadLine());
            double second = Convert.ToDouble(Console.ReadLine());
            string op = Console.ReadLine();
            switch (op)
            {
                case "+":
                    Console.Write($"Result: {first + second}");
                    break;
                case "-":
                    Console.Write($"Result: {first - second}");
                    break;
                case "*":
                    Console.Write($"Result: {first * second}");
                    break;
                case "/":
                    Console.Write($"Result: {first / second}");
                    break;
                default:
                    Console.Write("Invalid Operator");
                    break;
            }
        }
    }
}
