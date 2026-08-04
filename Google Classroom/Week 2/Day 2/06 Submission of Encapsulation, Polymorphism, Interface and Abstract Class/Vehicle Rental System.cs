using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_2._06_Submission_of_Encapsulation__Polymorphism__Interface_and_Abstract_Class
{
    internal class Vehicle_Rental_System
    {
        public void Demo()
        {
            Vehicle[] vehicles = new Vehicle[3];
            vehicles[0] = new Car("MH12AB1234", "Car", 1500);
            vehicles[1] = new Bike("MH14CD5678", "Bike", 500);
            vehicles[2] = new Truck("MH15EF9012", "Truck", 3000);

            int days = 5;
            for (int i = 0; i < vehicles.Length; i++)
            {
                Console.WriteLine($"Vehicle: {vehicles[i].VehicleNumber}");
                Console.WriteLine($"Rental Cost for {days} days: {vehicles[i].CalculateRentalCost(days)}");
                if (vehicles[i] is IInsurable)
                {
                    IInsurable insurable = (IInsurable)vehicles[i];
                    Console.WriteLine($"Insurance: {insurable.CalculateInsurance()}");
                }
                Console.WriteLine();
            }
        }
    }

    interface IInsurable
    {
        double CalculateInsurance();
        string GetInsuranceDetails();
    }

    abstract class Vehicle
    {
        private string vehicleNumber;
        private string type;
        protected double rentalRate;

        public Vehicle (string number, string type, double rate)
        {
            this.vehicleNumber = number;
            this.type = type;
            this.rentalRate = rate;
        }

        public string VehicleNumber
        {
            get { return vehicleNumber; }
        }

        public string Type
        {
            get { return type; }
        }

        public double RentalRate
        {
            get { return rentalRate; }
            set 
            { 
                if (value > 0)
                    rentalRate = value; 
            }
        }

        public abstract double CalculateRentalCost(int days);
    }

    class Car : Vehicle, IInsurable
    {
        public Car (string number, string type, double rate) : base(number, type, rate)
        {
        }

        public override double CalculateRentalCost(int days)
        {
            return rentalRate * days;
        }

        public double CalculateInsurance()
        {
            return 500;
        }

        public string GetInsuranceDetails()
        {
            return "Car Insurance Policy";
        }
    }

    class Bike : Vehicle, IInsurable
    {
        public Bike (string number, string type, double rate) : base(number, type, rate)
        {
        }

        public override double CalculateRentalCost(int days)
        {
            return rentalRate * days;
        }

        public double CalculateInsurance()
        {
            return 200;
        }

        public string GetInsuranceDetails()
        {
            return "Bike Insurance Policy";
        }
    }

    class Truck : Vehicle
    {
        public Truck (string number, string type, double rate) : base(number, type, rate)
        {
        }

        public override double CalculateRentalCost(int days)
        {
            return rentalRate * days * 1.2;
        }
    }
}
