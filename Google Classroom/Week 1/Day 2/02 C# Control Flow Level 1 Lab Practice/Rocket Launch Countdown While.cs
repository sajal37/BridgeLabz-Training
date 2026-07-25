using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._02_C__Control_Flow_Level_1_Lab_Practice
{
    internal class Rocket_Launch_Countdown_While
    {
        public void Demo()
        {
            int counter = Convert.ToInt32(Console.ReadLine());
            while (counter >= 1)
            {
                Console.WriteLine(counter);
                counter--;
            }
        }
    }
}
