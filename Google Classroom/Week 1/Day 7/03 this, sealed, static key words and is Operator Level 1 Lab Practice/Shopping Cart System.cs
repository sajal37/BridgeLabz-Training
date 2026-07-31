using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Google_Classroom.Week_1.Day_7._03_this__sealed__static_key_words_and_is_Operator_Level_1_Lab_Practice
{
    internal class Shopping_Cart_System
    {
        public static void Main(string[] args)
        {
            Product p1 = new Product("Laptop", 75000, 1, "P001");
            Product p2 = new Product("Mouse", 500, 3, "P002");
            DisplayProductInfo(p1);
            DisplayProductInfo(p2);
            Product.UpdateDiscount(15);
            DisplayProductInfo(p1);
        }
        public static void DisplayProductInfo(object obj)
        {
            if (obj is Product p)
            {
                p.Display();
            }
        }
    }
    public class Product
    {
        public static double discount = 10;
        private string productName;
        private double price;
        private int quantity;
        public readonly string productID;
        public Product(string productName, double price, int quantity, string productID)
        {
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
            this.productID = productID;
        }
        public void Display()
        {
            Console.WriteLine($"Product {productName} with ID {productID} costs {price} and quantity is {quantity} with discount {discount}%");
        }
        public static void UpdateDiscount(double newDiscount)
        {
            discount = newDiscount;
            Console.WriteLine($"Discount updated to {discount}%");
        }
    }
}
