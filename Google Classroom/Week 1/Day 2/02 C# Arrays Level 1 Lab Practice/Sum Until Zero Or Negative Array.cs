using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Arrays_Level_1_Lab_Practice
{
    internal class Sum_Until_Zero_Or_Negative_Array
    {
        public void Demo()
        {
            double[] numbers = new double[10];
            double total = 0.0;
            int index = 0;
            while (true)
            {
                double num = Convert.ToDouble(Console.ReadLine());
                if (num <= 0 || index == 10)
                    break;
                numbers[index] = num;
                index++;
            }
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(numbers[i]);
                total += numbers[i];
            }
            Console.Write($"Total sum: {total}");
        }
    }
}
