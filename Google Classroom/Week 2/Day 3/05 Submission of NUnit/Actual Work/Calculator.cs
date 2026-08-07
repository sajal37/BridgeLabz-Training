using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Actual_Work
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            int Sum = a + b;
            return Sum;
        }

        public int Subtract(int a, int b)
        {
            int Difference = a - b;
            return Difference;
        }

        public int Multiply(int a, int b)
        {
            int Product = a * b;
            return Product;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero");
            int Quotient = a / b;
            return Quotient;
        }
    }
}
