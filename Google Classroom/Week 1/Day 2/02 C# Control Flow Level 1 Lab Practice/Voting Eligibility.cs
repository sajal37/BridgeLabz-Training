using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Control_Flow_Level_1_Lab_Practice
{
    internal class Voting_Eligibility
    {
        public void Demo()
        {
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
                Console.Write($"The person's age is {age} and can vote.");
            else
                Console.Write($"The person's age is {age} and cannot vote.");
        }
    }
}
