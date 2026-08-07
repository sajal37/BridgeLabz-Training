using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Actual_Work
{
    public class MathOperations
    {
        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new ArithmeticException("Division by zero is not allowed");
            int Result = a / b;
            return Result;
        }

        public bool IsEven(int number)
        {
            bool Even = number % 2 == 0;
            return Even;
        }

        public string LongRunningTask()
        {
            System.Threading.Thread.Sleep(3000);
            return "Task Completed";
        }
    }
}
