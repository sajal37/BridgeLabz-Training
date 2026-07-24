using System;
using System.Collections.Generic;
using System.Text;

// Create SumOfDigit Class to compute the sum of all digits of a number using
// an array

namespace Arrays.Arrays
{
    internal class sumOfDigit
    {
        public void Demo()
        {
            Console.Write("Enter a number: ");  //123
            int num = Convert.ToInt32(Console.ReadLine());
            int ans = 0;
            while(num!=0)
            {
                int rem = num % 10;
                num /= 10;
                ans += rem;
            }
            Console.WriteLine($"The sum of the digits is {ans}");
        }
    }
}
