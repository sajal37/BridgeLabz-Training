using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_2._06_Submission_of_Encapsulation__Polymorphism__Interface_and_Abstract_Class
{
    internal class Ride_Hailing_Application
    {
        public void Demo()
        {
            Vehicle[] vehicles = new Vehicle[3];
            vehicles[0] = new Car(101, "Ramesh Kumar", 15);
            vehicles[1] = new Bike(102, "Sunil Yadav", 10);
            vehicles[2] = new Auto(103, "Prakash Singh", 12);

            double distance = 10.5;
            for (int i = 0; i < vehicles.Length; i++)
            {
                vehicles[i].GetVehicleDetails();
                Console.WriteLine($"Fare for {distance} km: {vehicles[i].CalculateFare(distance)}");
                if (vehicles[i] is IGPS)
                {
                    IGPS gps = (IGPS)vehicles[i];
                    Console.WriteLine($"Current Location: {gps.GetCurrentLocation()}");
                }
                Console.WriteLine();
            }
        }
    }

    interface IGPS
    {
        string GetCurrentLocation();
        void UpdateLocation(string location);
    }

    abstract class Vehicle
    {
        private int vehicleId;
        private string driverName;
        protected double ratePerKm;

        public Vehicle (int id, string driver, double rate)
        {
            this.vehicleId = id;
            this.driverName = driver;
            this.ratePerKm = rate;
        }

        public int VehicleId
        {
            get { return vehicleId; }
        }

        public string DriverName
        {
            get { return driverName; }
            set { driverName = value; }
        }

        public double RatePerKm
        {
            get { return ratePerKm; }
            set 
            { 
                if (value > 0)
                    ratePerKm = value; 
            }
        }

        public abstract double CalculateFare(double distance);

        public void GetVehicleDetails()
        {
            Console.WriteLine($"Vehicle ID: {vehicleId}, Driver: {driverName}, Rate: {ratePerKm}/km");
        }
    }

    class Car : Vehicle, IGPS
    {
        public Car (int id, string driver, double rate) : base(id, driver, rate)
        {
        }

        public override double CalculateFare(double distance)
        {
            return distance * ratePerKm;
        }

        public string GetCurrentLocation()
        {
            return "MG Road, Pune";
        }

        public void UpdateLocation(string location)
        {
            Console.WriteLine($"Location updated to {location}");
        }
    }

    class Bike : Vehicle, IGPS
    {
        public Bike (int id, string driver, double rate) : base(id, driver, rate)
        {
        }

        public override double CalculateFare(double distance)
        {
            return distance * ratePerKm;
        }

        public string GetCurrentLocation()
        {
            return "FC Road, Pune";
        }

        public void UpdateLocation(string location)
        {
            Console.WriteLine($"Location updated to {location}");
        }
    }

    class Auto : Vehicle
    {
        public Auto (int id, string driver, double rate) : base(id, driver, rate)
        {
        }

        public override double CalculateFare(double distance)
        {
            return distance * ratePerKm + 10;
        }
    }
}
