using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._04_C__Methods_Level_3_Practice_Programs
{
    internal class Zara_Employee_Bonus_Generator
    {
        public static double[,] GenerateEmployeeData(int count)
        {
            Random random = new Random();
            double[,] data = new double[count, 2];
            for (int i = 0; i < count; i++)
            {
                data[i, 0] = random.Next(10000, 100000);
                data[i, 1] = random.Next(1, 16);
            }
            return data;
        }
        public static double[,] CalcBonus(double[,] data)
        {
            int count = data.GetLength(0);
            double[,] result = new double[count, 2];
            for (int i = 0; i < count; i++)
            {
                double salary = data[i, 0];
                double years = data[i, 1];
                double bonusPct = years > 5 ? 0.05 : 0.02;
                double bonus = salary * bonusPct;
                double newSal = salary + bonus;
                result[i, 0] = newSal;
                result[i, 1] = bonus;
            }
            return result;
        }
        public void Demo()
        {
            int count = 10;
            double[,] empData = GenerateEmployeeData(count);
            double[,] bonusData = CalcBonus(empData);
            double totalOldSal = 0;
            double totalNewSal = 0;
            double totalBonus = 0;
            Console.WriteLine("Emp\tOld Salary\tYears\tBonus\t\tNew Salary");
            for (int i = 0; i < count; i++)
            {
                double oldSal = empData[i, 0];
                double years = empData[i, 1];
                double newSal = bonusData[i, 0];
                double bonus = bonusData[i, 1];
                totalOldSal += oldSal;
                totalNewSal += newSal;
                totalBonus += bonus;
                Console.WriteLine($"{i + 1}\t{oldSal}\t\t{years}\t{bonus}\t\t{newSal}");
            }
            Console.WriteLine($"Total Old Salary: {totalOldSal}");
            Console.WriteLine($"Total Bonus: {totalBonus}");
            Console.Write($"Total New Salary: {totalNewSal}");
        }
    }
}
