using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_2._03_C__Arrays_Level_2_Lab_Practice
{
    internal class Employee_Bonus_Zara
    {
        public void Demo()
        {
            double[] salary = new double[10];
            double[] years = new double[10];
            double[] bonus = new double[10];
            double[] newSalary = new double[10];
            double totalBonus = 0.0;
            double totalOldSalary = 0.0;
            double totalNewSalary = 0.0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter salary and years of service for employee {i + 1}: ");
                double sal = Convert.ToDouble(Console.ReadLine());
                double yr = Convert.ToDouble(Console.ReadLine());
                if (sal <= 0 || yr < 0)
                {
                    i--;
                    continue;
                }
                salary[i] = sal;
                years[i] = yr;
            }
            for (int i = 0; i < 10; i++)
            {
                if (years[i] > 5)
                    bonus[i] = salary[i] * 0.05;
                else
                    bonus[i] = salary[i] * 0.02;
                newSalary[i] = salary[i] + bonus[i];
                totalOldSalary += salary[i];
                totalBonus += bonus[i];
                totalNewSalary += newSalary[i];
            }
            Console.WriteLine($"Total Old Salary: {totalOldSalary}");
            Console.WriteLine($"Total Bonus Payout: {totalBonus}");
            Console.Write($"Total New Salary: {totalNewSalary}");
        }
    }
}
