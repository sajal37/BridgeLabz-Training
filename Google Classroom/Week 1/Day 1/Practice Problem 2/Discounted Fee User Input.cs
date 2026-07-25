using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_2
{
    internal class Discounted_Fee_UserInput
    {
        public void Demo()
        {
            Console.Write("Enter fee (INR): ");
            double fee = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter discount percent: ");
            double discountPercent = Convert.ToDouble(Console.ReadLine());
            double discount = (fee * discountPercent) / 100.0;
            double finalFee = fee - discount;
            Console.WriteLine($"Discount: INR {discount}, Final: INR {finalFee}");
        }
    }
}
