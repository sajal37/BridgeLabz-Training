using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_2
{
    internal class University_Discount_Fee
    {
        public void Demo()
        {
            double fee = 125000.0;
            double discountPercent = 10.0;
            double discount = (fee * discountPercent) / 100.0;
            double finalFee = fee - discount;
            Console.WriteLine($"Discount: INR {discount}, Final: INR {finalFee}");
        }
    }
}
