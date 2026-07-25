using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Arrays_Level_1_Lab_Practice
{
    internal class Factors_Array
    {
        public void Demo()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int maxFactor = 10;
            int[] factors = new int[maxFactor];
            int index = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    if (index == maxFactor)
                    {
                        maxFactor *= 2;
                        int[] temp = new int[maxFactor];
                        for (int j = 0; j < factors.Length; j++)
                            temp[j] = factors[j];
                        factors = temp;
                    }
                    factors[index] = i;
                    index++;
                }
            }
            for (int i = 0; i < index; i++)
                Console.WriteLine(factors[i]);
        }
    }
}
