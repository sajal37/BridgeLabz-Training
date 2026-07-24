using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_3
{
    internal class Chocolate_Distribution
    {
        public void Demo()
        {
            Console.Write("Enter number of chocolates: ");
            int chocolates = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of children: ");
            int children = Convert.ToInt32(Console.ReadLine());
            int each = chocolates / children;
            int remaining = chocolates % children;
            Console.WriteLine($"Each: {each}, Remaining: {remaining}");
        }
    }
}
