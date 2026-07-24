using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_3
{
    internal class Total_Income
    {
        public void Demo()
        {
            Console.Write("Enter salary (INR): ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter bonus (INR): ");
            double bonus = Convert.ToDouble(Console.ReadLine());
            double total = salary + bonus;
            Console.WriteLine($"Salary: INR {salary}, Bonus: INR {bonus}, Total: INR {total}");
        }
    }
}
