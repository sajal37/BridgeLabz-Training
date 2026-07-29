using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_5.Problem_Statment
{
    internal class Basic_Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            return a / b;
        }
        public void Demo()
        {
            Console.WriteLine("Select operation (+, -, *, /): ");
            char op = Console.ReadLine()[0];
            Console.Write("Enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (op == '+')
                Console.Write($"Result: {Add(a, b)}");
            else if (op == '-')
                Console.Write($"Result: {Subtract(a, b)}");
            else if (op == '*')
                Console.Write($"Result: {Multiply(a, b)}");
            else if (op == '/')
                Console.Write($"Result: {Divide(a, b)}");
            else
                Console.Write("Invalid operation.");
        }
    }
}
