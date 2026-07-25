using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Arrays_Level_1_Lab_Practice
{
    internal class FizzBuzz_Array
    {
        public void Demo()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                string[] results = new string[number + 1];
                for (int i = 0; i <= number; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                        results[i] = "FizzBuzz";
                    else if (i % 3 == 0)
                        results[i] = "Fizz";
                    else if (i % 5 == 0)
                        results[i] = "Buzz";
                    else
                        results[i] = i.ToString();
                }
                for (int i = 0; i <= number; i++)
                    Console.WriteLine($"Position {i} = {results[i]}");
            }
        }
    }
}
