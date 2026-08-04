using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_2._06_Submission_of_Encapsulation__Polymorphism__Interface_and_Abstract_Class
{
    internal class Online_Food_Delivery_System
    {
        public void Demo()
        {
            FoodItem[] items = new FoodItem[2];
            items[0] = new VegItem("Paneer Tikka", 250, 2);
            items[1] = new NonVegItem("Chicken Biryani", 350, 1);

            for (int i = 0; i < items.Length; i++)
            {
                items[i].GetItemDetails();
                Console.WriteLine($"Total Price: {items[i].CalculateTotalPrice()}");
                if (items[i] is IDiscountable)
                {
                    IDiscountable discountable = (IDiscountable)items[i];
                    discountable.ApplyDiscount();
                }
                Console.WriteLine();
            }
        }
    }

    interface IDiscountable
    {
        void ApplyDiscount();
        double GetDiscountDetails();
    }

    abstract class FoodItem
    {
        private string itemName;
        protected double price;
        protected int quantity;

        public FoodItem (string name, double price, int qty)
        {
            this.itemName = name;
            this.price = price;
            this.quantity = qty;
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public double Price
        {
            get { return price; }
            set 
            { 
                if (value > 0)
                    price = value; 
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set 
            { 
                if (value > 0)
                    quantity = value; 
            }
        }

        public abstract double CalculateTotalPrice();

        public void GetItemDetails()
        {
            Console.WriteLine($"Item: {itemName}, Price: {price}, Quantity: {quantity}");
        }
    }

    class VegItem : FoodItem, IDiscountable
    {
        public VegItem (string name, double price, int qty) : base(name, price, qty)
        {
        }

        public override double CalculateTotalPrice()
        {
            return price * quantity;
        }

        public void ApplyDiscount()
        {
            Console.WriteLine("10% discount applied on Veg items");
        }

        public double GetDiscountDetails()
        {
            return 0.1;
        }
    }

    class NonVegItem : FoodItem
    {
        public NonVegItem (string name, double price, int qty) : base(name, price, qty)
        {
        }

        public override double CalculateTotalPrice()
        {
            double gst = price * quantity * 0.05;
            return price * quantity + gst;
        }
    }
}
