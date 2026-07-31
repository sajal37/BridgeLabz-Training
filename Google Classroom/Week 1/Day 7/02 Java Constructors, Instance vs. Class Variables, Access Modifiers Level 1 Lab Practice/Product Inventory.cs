using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_7._02_Java_Constructors__Instance_vs._Class_Variables__Access_Modifiers_Level_1_Lab_Practice
{
    internal class Product_Inventory
    {
        public static void Main(string[] args)
        {
            Product p1 = new Product("Laptop", 75000);
            Product p2 = new Product("Phone", 25000);
            p1.Display();
            p2.Display();
            Product.DisplayTotalProducts();
        }
    }
    public class Product
    {
        private string productName;
        private double price;
        public static int totalProducts;
        public Product (string productName, double price)
        {
            this.productName = productName;
            this.price = price;
            totalProducts++;
        }
        public void Display()
        {
            Console.WriteLine($"The product is {productName} and its price is {price}");
        }
        public static void DisplayTotalProducts()
        {
            Console.WriteLine($"Total products created are {totalProducts}");
        }
    }
}
