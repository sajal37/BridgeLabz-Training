using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_5.Problem_Statment
{
    internal class GCD_and_LCM_Calculator
    {
        public static int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public static int FindLCM(int a, int b)
        {
            int gcd = FindGCD(a, b);
            return (a * b) / gcd;
        }
        public void Demo()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int gcd = FindGCD(num1, num2);
            int lcm = FindLCM(num1, num2);
            Console.WriteLine($"GCD of {num1} and {num2}: {gcd}");
            Console.Write($"LCM of {num1} and {num2}: {lcm}");
        }
    }
}
