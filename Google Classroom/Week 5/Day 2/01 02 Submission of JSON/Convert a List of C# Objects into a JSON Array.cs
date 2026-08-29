using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Google_Classroom.Week_5.Day_2._01_02_Submission_of_JSON
{
    internal class Convert_a_List_of_C__Objects_into_a_JSON_Array
    {
        public static void Main(string[] args)
        {
            List<Product> products = new List<Product>() {
                new Product(1, "Laptop", 65000),
                new Product(2, "Mouse", 800),
                new Product(3, "Keyboard", 1500)
            };
            string jsonArray = JsonConvert.SerializeObject(products, Formatting.Indented);
            Console.WriteLine(jsonArray);
        }
    }
    class Product
    {
        public int id;
        public string name;
        public double price;
        public Product (int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
    }
}
