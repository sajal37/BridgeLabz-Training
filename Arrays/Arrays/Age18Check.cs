using System;
using System.Collections.Generic;
using System.Text;

//Write a program to take user input for the age of all 10 students in a class and check
//whether the student can vote depending on his/her age is greater or equal to 18.

namespace Arrays.Arrays
{
    internal class Age18Check
    {
        public void Demo()
        {
            int[] arr = new int[10];
            Console.Write("Write the age of 10 students: ");
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i]<0)
                {
                    Console.WriteLine("Invalid age");
                } else if (arr[i]<18)
                {
                    Console.WriteLine("You cannot vote");
                } else
                {
                    Console.WriteLine("You can vote");
                }
            }
        }
    }
}
