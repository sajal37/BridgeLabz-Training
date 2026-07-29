using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_5.Problem_Statment
{
    internal class Number_Guessing_Game
    {
        public static int GenerateGuess(int low, int high)
        {
            return (low + high) / 2;
        }
        public static string GetUserFeedback()
        {
            Console.Write("Is the guess high (h), low (l), or correct (c)? ");
            return Console.ReadLine();
        }
        public static void PlayGame()
        {
            Console.WriteLine("Think of a number between 1 and 100.");
            int low = 1;
            int high = 100;
            bool guessed = false;
            while (!guessed && low <= high)
            {
                int guess = GenerateGuess(low, high);
                Console.WriteLine($"Computer guesses: {guess}");
                string feedback = GetUserFeedback();
                if (feedback == "c")
                {
                    Console.Write($"Computer guessed your number: {guess}");
                    guessed = true;
                }
                else if (feedback == "h")
                    high = guess - 1;
                else if (feedback == "l")
                    low = guess + 1;
            }
        }
        public void Demo()
        {
            PlayGame();
        }
    }
}
