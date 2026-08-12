using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_2.Submission_of_Data_Structure___LinkedList
{
    internal class Inventory_Management_System
    {
        public static void Main(string[] args)
        {
            InventoryList inv1 = new InventoryList();

            inv1.AddItemAtEnd("Laptop", 501, 10, 65000);
            inv1.AddItemAtEnd("Mouse", 502, 50, 500);
            inv1.AddItemAtBeginning("Keyboard", 500, 30, 1500);

            Console.WriteLine("All Inventory Items:");
            inv1.DisplayAll();

            Console.WriteLine("\nUpdating Quantity of Item ID 502 to 60:");
            inv1.UpdateQuantity(502, 60);

            Console.WriteLine("\nSearching for 'Laptop':");
            inv1.SearchByName("Laptop");

            Console.WriteLine("\nTotal Inventory Value:");
            inv1.CalculateTotalValue();

            Console.WriteLine("\nSorting Inventory by Price Ascending:");
            inv1.SortByPrice(true);
            inv1.DisplayAll();

            Console.WriteLine("\nRemoving Item ID 500:");
            inv1.RemoveById(500);

            Console.WriteLine("\nFinal Inventory:");
            inv1.DisplayAll();
        }
    }

    class InventoryNode
    {
        public string name;
        public int itemId;
        public int quantity;
        public double price;
        public InventoryNode next;

        public InventoryNode (string name, int itemId, int quantity, double price)
        {
            this.name = name;
            this.itemId = itemId;
            this.quantity = quantity;
            this.price = price;
            this.next = null;
        }
    }

    class InventoryList
    {
        private InventoryNode head;

        public void AddItemAtBeginning(string name, int id, int qty, double price)
        {
            InventoryNode newNode = new InventoryNode(name, id, qty, price);
            newNode.next = head;
            head = newNode;
        }

        public void AddItemAtEnd(string name, int id, int qty, double price)
        {
            InventoryNode newNode = new InventoryNode(name, id, qty, price);
            if (head == null)
            {
                head = newNode;
                return;
            }
            InventoryNode temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
        }

        public void RemoveById(int id)
        {
            if (head == null) return;
            if (head.itemId == id)
            {
                head = head.next;
                return;
            }
            InventoryNode curr = head;
            while (curr.next != null && curr.next.itemId != id)
            {
                curr = curr.next;
            }
            if (curr.next != null)
            {
                curr.next = curr.next.next;
            }
        }

        public void UpdateQuantity(int id, int newQty)
        {
            InventoryNode temp = head;
            while (temp != null)
            {
                if (temp.itemId == id)
                {
                    temp.quantity = newQty;
                    Console.WriteLine($"Updated Item ID {id} quantity to {newQty}");
                    return;
                }
                temp = temp.next;
            }
        }

        public void SearchById(int id)
        {
            InventoryNode temp = head;
            while (temp != null)
            {
                if (temp.itemId == id)
                {
                    Console.WriteLine($"Found Item: ID {temp.itemId}, Name: {temp.name}, Qty: {temp.quantity}, Price: {temp.price}");
                    return;
                }
                temp = temp.next;
            }
        }

        public void SearchByName(string name)
        {
            InventoryNode temp = head;
            while (temp != null)
            {
                if (temp.name == name)
                {
                    Console.WriteLine($"Found Item: ID {temp.itemId}, Name: {temp.name}, Qty: {temp.quantity}, Price: {temp.price}");
                    return;
                }
                temp = temp.next;
            }
        }

        public void CalculateTotalValue()
        {
            double totalValue = 0;
            InventoryNode temp = head;
            while (temp != null)
            {
                totalValue += temp.price * temp.quantity;
                temp = temp.next;
            }
            Console.WriteLine($"Total Inventory Value: {totalValue}");
        }

        public void SortByPrice(bool ascending)
        {
            if (head == null || head.next == null) return;

            for (InventoryNode i = head; i != null; i = i.next)
            {
                for (InventoryNode j = i.next; j != null; j = j.next)
                {
                    bool swap = ascending ? (i.price > j.price) : (i.price < j.price);
                    if (swap)
                    {
                        string tempName = i.name; i.name = j.name; j.name = tempName;
                        int tempId = i.itemId; i.itemId = j.itemId; j.itemId = tempId;
                        int tempQty = i.quantity; i.quantity = j.quantity; j.quantity = tempQty;
                        double tempPrice = i.price; i.price = j.price; j.price = tempPrice;
                    }
                }
            }
        }

        public void DisplayAll()
        {
            InventoryNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"ID: {temp.itemId}, Name: {temp.name}, Qty: {temp.quantity}, Price: {temp.price}");
                temp = temp.next;
            }
            Console.Write("End of Inventory");
        }
    }
}
