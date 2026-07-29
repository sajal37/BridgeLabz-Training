using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_5.Problem_Statment
{
    internal class Maximum_of_Three_Numbers
    {
        public static int FindMax(int a, int b, int c)
        {
            int max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;
            return max;
        }
        public void Demo()
        {
            Console.WriteLine("Enter three numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int max = FindMax(num1, num2, num3);
            Console.Write($"Maximum: {max}");
        }
    }
}
