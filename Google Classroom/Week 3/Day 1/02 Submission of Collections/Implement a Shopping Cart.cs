using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_1._02_Submission_of_Collections
{
    internal class Implement_a_Shopping_Cart
    {
        public static void Main(string[] args)
        {
            Dictionary<string, double> cart = new Dictionary<string, double>();
            LinkedList<string> itemOrder = new LinkedList<string>();

            cart["Laptop"] = 65000;
            itemOrder.AddLast("Laptop");

            cart["Mouse"] = 500;
            itemOrder.AddLast("Mouse");

            cart["Keyboard"] = 1500;
            itemOrder.AddLast("Keyboard");

            cart["Headphones"] = 3000;
            itemOrder.AddLast("Headphones");

            Console.WriteLine("Shopping Cart Items in Insertion Order:");
            foreach (string item in itemOrder)
            {
                Console.WriteLine($"{item}: {cart[item]}");
            }

            SortedDictionary<double, string> sortedByPrice = new SortedDictionary<double, string>();
            foreach (KeyValuePair<string, double> entry in cart)
            {
                sortedByPrice[entry.Value] = entry.Key;
            }

            Console.WriteLine("\nShopping Cart Items Sorted by Price:");
            foreach (KeyValuePair<double, string> entry in sortedByPrice)
            {
                Console.WriteLine($"Price {entry.Key} for item {entry.Value}");
            }
        }
    }
}
