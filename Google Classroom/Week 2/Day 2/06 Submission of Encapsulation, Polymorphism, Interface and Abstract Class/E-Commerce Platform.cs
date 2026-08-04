using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_2._06_Submission_of_Encapsulation__Polymorphism__Interface_and_Abstract_Class
{
    internal class E_Commerce_Platform
    {
        public void Demo()
        {
            Product[] products = new Product[3];
            products[0] = new Electronics(1, "Laptop", 50000);
            products[1] = new Clothing(2, "Shirt", 1500);
            products[2] = new Groceries(3, "Rice", 500);

            for (int i = 0; i < products.Length; i++)
            {
                double discount = products[i].CalculateDiscount();
                double tax = 0;
                if (products[i] is ITaxable)
                {
                    ITaxable taxable = (ITaxable)products[i];
                    tax = taxable.CalculateTax();
                }
                double finalPrice = products[i].Price + tax - discount;
                Console.WriteLine($"Product: {products[i].Name}, Final Price: {finalPrice}");
            }
        }
    }

    interface ITaxable
    {
        double CalculateTax();
        string GetTaxDetails();
    }

    abstract class Product
    {
        private int productId;
        private string name;
        private double price;

        public Product (int id, string name, double price)
        {
            this.productId = id;
            this.name = name;
            this.price = price;
        }

        public int ProductId
        {
            get { return productId; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
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

        public abstract double CalculateDiscount();
    }

    class Electronics : Product, ITaxable
    {
        public Electronics (int id, string name, double price) : base(id, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return Price * 0.1;
        }

        public double CalculateTax()
        {
            return Price * 0.18;
        }

        public string GetTaxDetails()
        {
            return "GST 18%";
        }
    }

    class Clothing : Product, ITaxable
    {
        public Clothing (int id, string name, double price) : base(id, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return Price * 0.05;
        }

        public double CalculateTax()
        {
            return Price * 0.12;
        }

        public string GetTaxDetails()
        {
            return "GST 12%";
        }
    }

    class Groceries : Product
    {
        public Groceries (int id, string name, double price) : base(id, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return 0;
        }
    }
}
