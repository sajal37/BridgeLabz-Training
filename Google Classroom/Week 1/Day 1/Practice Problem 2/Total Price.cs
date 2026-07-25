using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_2
{
    internal class Total_Price
    {
        public void Demo()
        {
            Console.Write("Enter unit price (INR): ");
            double unitPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            double total = unitPrice * quantity;
            Console.WriteLine($"Total: INR {total}");
        }
    }
}
