using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._04_C__Methods_Level_3_Practice_Programs
{
    internal class Student_Scorecard_Generator
    {
        public static double[,] GeneratePCMScores(int students)
        {
            Random random = new Random();
            double[,] scores = new double[students, 3];
            for (int i = 0; i < students; i++)
            {
                scores[i, 0] = random.Next(10, 100);
                scores[i, 1] = random.Next(10, 100);
                scores[i, 2] = random.Next(10, 100);
            }
            return scores;
        }
        public static double[,] CalcStats(double[,] scores)
        {
            int students = scores.GetLength(0);
            double[,] stats = new double[students, 3];
            for (int i = 0; i < students; i++)
            {
                double total = scores[i, 0] + scores[i, 1] + scores[i, 2];
                double avg = total / 3.0;
                double pct = (total / 300.0) * 100.0;
                stats[i, 0] = Math.Round(total, 2);
                stats[i, 1] = Math.Round(avg, 2);
                stats[i, 2] = Math.Round(pct, 2);
            }
            return stats;
        }
        public void Demo()
        {
            Console.Write("Enter number of students: ");
            int students = Convert.ToInt32(Console.ReadLine());
            double[,] pcm = GeneratePCMScores(students);
            double[,] stats = CalcStats(pcm);
            Console.WriteLine("Std\tPhysics\tChem\tMaths\tTotal\tAvg\tPercentage");
            for (int i = 0; i < students; i++)
            {
                Console.WriteLine($"{i + 1}\t{pcm[i, 0]}\t{pcm[i, 1]}\t{pcm[i, 2]}\t{stats[i, 0]}\t{stats[i, 1]}\t{stats[i, 2]}%");
            }
        }
    }
}
