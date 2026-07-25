using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_3
{
    internal class Int_Operation
    {
        public void Demo()
        {
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int r1 = a + b * c;
            int r2 = a * b + c;
            int r3 = c + a / b;
            int r4 = a % b + c;
            Console.WriteLine($"Results: {r1}, {r2}, {r3}, {r4}");
        }
    }
}
