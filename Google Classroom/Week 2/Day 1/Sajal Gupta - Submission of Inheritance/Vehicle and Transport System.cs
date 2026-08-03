using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_1.Sajal_Gupta___Submission_of_Inheritance
{
    internal class Vehicle_and_Transport_System
    {
        public void Demo()
        {
            Vehicle[] vehicles = new Vehicle[3];
            vehicles[0] = new Car(180, "Petrol", 5);
            vehicles[1] = new Truck(120, "Diesel", 5000);
            vehicles[2] = new Motorcycle(200, "Petrol", false);

            for (int i = 0; i < vehicles.Length; i++)
            {
                vehicles[i].DisplayInfo();
            }
        }
    }

    class Vehicle
    {
        protected int MaxSpeed;
        protected string FuelType;

        public Vehicle (int maxSpeed, string fuelType)
        {
            this.MaxSpeed = maxSpeed;
            this.FuelType = fuelType;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Max Speed: {MaxSpeed} km/h, Fuel Type: {FuelType}");
        }
    }

    class Car : Vehicle
    {
        private int SeatCapacity;

        public Car (int maxSpeed, string fuelType, int seats) : base(maxSpeed, fuelType)
        {
            this.SeatCapacity = seats;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Car - Max Speed: {MaxSpeed} km/h, Fuel Type: {FuelType}, Seats: {SeatCapacity}");
        }
    }

    class Truck : Vehicle
    {
        private int PayloadCapacity;

        public Truck (int maxSpeed, string fuelType, int payload) : base(maxSpeed, fuelType)
        {
            this.PayloadCapacity = payload;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Truck - Max Speed: {MaxSpeed} km/h, Fuel Type: {FuelType}, Payload: {PayloadCapacity} kg");
        }
    }

    class Motorcycle : Vehicle
    {
        private bool HasSidecar;

        public Motorcycle (int maxSpeed, string fuelType, bool sidecar) : base(maxSpeed, fuelType)
        {
            this.HasSidecar = sidecar;
        }

        public override void DisplayInfo()
        {
            string sidecarInfo = HasSidecar ? "with sidecar" : "without sidecar";
            Console.WriteLine($"Motorcycle - Max Speed: {MaxSpeed} km/h, Fuel Type: {FuelType}, {sidecarInfo}");
        }
    }
}
