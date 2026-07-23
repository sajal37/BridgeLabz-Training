using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Basics
{
    internal class input
    {
        public void Demo()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your name is {name} and age is {age}");
        }
    }
}
