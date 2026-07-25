using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Arrays_Level_1_Lab_Practice
{
    internal class Odd_And_Even_Arrays
    {
        public void Demo()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number <= 0)
                return;
            int size = number / 2 + 1;
            int[] even = new int[size];
            int[] odd = new int[size];
            int evenIndex = 0;
            int oddIndex = 0;
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    even[evenIndex] = i;
                    evenIndex++;
                }
                else
                {
                    odd[oddIndex] = i;
                    oddIndex++;
                }
            }
            Console.WriteLine("Even numbers:");
            for (int i = 0; i < evenIndex; i++)
                Console.WriteLine(even[i]);
            Console.WriteLine("Odd numbers:");
            for (int i = 0; i < oddIndex; i++)
                Console.WriteLine(odd[i]);
        }
    }
}
