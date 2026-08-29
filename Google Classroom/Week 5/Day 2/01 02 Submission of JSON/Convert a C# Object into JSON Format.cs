using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Google_Classroom.Week_5.Day_2._01_02_Submission_of_JSON
{
    internal class Convert_a_C__Object_into_JSON_Format
    {
        public static void Main(string[] args)
        {
            Car car1 = new Car("Tesla", "Model 3", 2024, 45000.50);
            string json = JsonConvert.SerializeObject(car1, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
    class Car
    {
        public string make;
        public string model;
        public int year;
        public double price;
        public Car (string make, string model, int year, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }
    }
}
