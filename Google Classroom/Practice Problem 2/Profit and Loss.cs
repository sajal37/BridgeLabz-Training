using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_2
{
    internal class Profit_and_Loss
    {
        public void Demo()
        {
            double costPrice = 129.0;
            double sellingPrice = 191.0;
            double profit = sellingPrice - costPrice;
            double profitPercent = (profit / costPrice) * 100.0;
            Console.WriteLine($"Cost: INR {costPrice}, Sell: INR {sellingPrice}");
            Console.WriteLine($"Profit: INR {profit}, Profit%: {profitPercent}");
        }
    }
}
