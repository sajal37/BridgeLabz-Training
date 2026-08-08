using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_4._01___Submission_of_C__Generics
{
    internal class Smart_Warehouse_Management_System
    {
        public static void Main(string[] args)
        {
            Storage<Electronics> electronicsStorage = new Storage<Electronics>();
            electronicsStorage.AddItem(new Electronics("Laptop", 899.99, 15, "Dell", 2));
            electronicsStorage.AddItem(new Electronics("Smartphone", 599.99, 30, "Samsung", 1));

            Storage<Groceries> groceriesStorage = new Storage<Groceries>();
            groceriesStorage.AddItem(new Groceries("Milk", 3.99, 50, "2026-08-15", "Dairy"));
            groceriesStorage.AddItem(new Groceries("Bread", 2.49, 100, "2026-08-10", "Bakery"));

            Storage<Furniture> furnitureStorage = new Storage<Furniture>();
            furnitureStorage.AddItem(new Furniture("Office Chair", 149.99, 20, "Leather", "24x24x36 inches"));

            electronicsStorage.DisplayAllItems();
            groceriesStorage.DisplayAllItems();
            furnitureStorage.DisplayAllItems();
        }
    }
    public abstract class WarehouseItem
    {
        public string name;
        public double price;
        public int quantity;

        public WarehouseItem(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public abstract void DisplayDetails();
    }

    public class Electronics : WarehouseItem
    {
        public string brand;
        public int warrantyYears;

        public Electronics(string name, double price, int quantity, string brand, int warrantyYears) : base(name, price, quantity)
        {
            this.brand = brand;
            this.warrantyYears = warrantyYears;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Electronics: {name}, Brand: {brand}, Price: ${price}, Quantity: {quantity}, Warranty: {warrantyYears} years");
        }
    }

    public class Groceries : WarehouseItem
    {
        public string expiryDate;
        public string category;

        public Groceries(string name, double price, int quantity, string expiryDate, string category) : base(name, price, quantity)
        {
            this.expiryDate = expiryDate;
            this.category = category;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Grocery: {name}, Category: {category}, Price: ${price}, Quantity: {quantity}, Expiry: {expiryDate}");
        }
    }

    public class Furniture : WarehouseItem
    {
        public string material;
        public string dimensions;

        public Furniture(string name, double price, int quantity, string material, string dimensions) : base(name, price, quantity)
        {
            this.material = material;
            this.dimensions = dimensions;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Furniture: {name}, Material: {material}, Dimensions: {dimensions}, Price: ${price}, Quantity: {quantity}");
        }
    }

    public class Storage<T> where T : WarehouseItem
    {
        private List<T> items;

        public Storage()
        {
            items = new List<T>();
        }

        public void AddItem(T item)
        {
            items.Add(item);
            Console.WriteLine($"{item.name} added to storage");
        }

        public void DisplayAllItems()
        {
            Console.WriteLine($"\nStorage Contents ({items.Count} items):");
            foreach(T item in items)
            {
                item.DisplayDetails();
            }
        }
    }
}
