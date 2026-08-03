using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_1.Sajal_Gupta___Submission_of_Inheritance
{
    internal class Online_Retail_Order_Management
    {
        public void Demo()
        {
            Order order1 = new Order(1001, "2024-01-15");
            ShippedOrder order2 = new ShippedOrder(1002, "2024-01-16", "TRK987654321");
            DeliveredOrder order3 = new DeliveredOrder(1003, "2024-01-17", "TRK123456789", "2024-01-20");

            Console.WriteLine(order1.GetOrderStatus());
            Console.WriteLine(order2.GetOrderStatus());
            Console.WriteLine(order3.GetOrderStatus());
        }
    }

    class Order
    {
        protected int orderId;
        protected string OrderDate;

        public Order (int id, string date)
        {
            this.orderId = id;
            this.OrderDate = date;
        }

        public virtual string GetOrderStatus()
        {
            return $"Order {orderId} placed on {OrderDate} - Status: Pending";
        }
    }

    class ShippedOrder : Order
    {
        protected string TrackingNumber;

        public ShippedOrder (int id, string date, string tracking) : base(id, date)
        {
            this.TrackingNumber = tracking;
        }

        public override string GetOrderStatus()
        {
            return $"Order {orderId} placed on {OrderDate} - Status: Shipped (Tracking: {TrackingNumber})";
        }
    }

    class DeliveredOrder : ShippedOrder
    {
        private string DeliveryDate;

        public DeliveredOrder (int id, string date, string tracking, string deliveryDate) : base(id, date, tracking)
        {
            this.DeliveryDate = deliveryDate;
        }

        public override string GetOrderStatus()
        {
            return $"Order {orderId} placed on {OrderDate} - Status: Delivered on {DeliveryDate} (Tracking: {TrackingNumber})";
        }
    }
}
