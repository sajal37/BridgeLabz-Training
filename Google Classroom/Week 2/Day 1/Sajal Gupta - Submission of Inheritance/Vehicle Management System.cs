using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_1.Sajal_Gupta___Submission_of_Inheritance
{
    internal class Vehicle_Management_System
    {
        public void Demo()
        {
            ElectricVehicle ev = new ElectricVehicle(150, "Tesla Model 3");
            PetrolVehicle pv = new PetrolVehicle(200, "Honda Civic");

            ev.DisplayInfo();
            ev.Charge();

            pv.DisplayInfo();
            pv.Refuel();
        }
    }

    interface Refuelable
    {
        void Refuel();
    }

    class Vehicle
    {
        protected int MaxSpeed;
        protected string Model;

        public Vehicle (int speed, string model)
        {
            this.MaxSpeed = speed;
            this.Model = model;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle Model: {Model}, Max Speed: {MaxSpeed} km/h");
        }
    }

    class ElectricVehicle : Vehicle
    {
        public ElectricVehicle (int speed, string model) : base(speed, model)
        {
        }

        public void Charge()
        {
            Console.WriteLine($"{Model} is charging the battery");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Electric Vehicle - Model: {Model}, Max Speed: {MaxSpeed} km/h");
        }
    }

    class PetrolVehicle : Vehicle, Refuelable
    {
        public PetrolVehicle (int speed, string model) : base(speed, model)
        {
        }

        public void Refuel()
        {
            Console.WriteLine($"{Model} is refueling with petrol");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Petrol Vehicle - Model: {Model}, Max Speed: {MaxSpeed} km/h");
        }
    }
}
