using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_7._03_this__sealed__static_key_words_and_is_Operator_Level_1_Lab_Practice
{
    internal class Vehicle_Registration_System
    {
        public static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle("Suresh Kumar", "Car", "MH01AB1234");
            Vehicle v2 = new Vehicle("Meena Patel", "Bike", "MH02CD5678");
            DisplayVehicleInfo(v1);
            DisplayVehicleInfo(v2);
            Vehicle.UpdateRegistrationFee(2500);
        }
        public static void DisplayVehicleInfo(object obj)
        {
            if (obj is Vehicle v)
            {
                v.Display();
            }
        }
    }
    class Vehicle
    {
        public static double registrationFee = 1500;
        private string ownerName;
        private string vehicleType;
        public readonly string registrationNumber;
        public Vehicle(string ownerName, string vehicleType, string registrationNumber)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
            this.registrationNumber = registrationNumber;
        }
        public void Display()
        {
            Console.WriteLine($"{ownerName} owns a {vehicleType} with registration {registrationNumber} and fee {registrationFee}");
        }
        public static void UpdateRegistrationFee(double newFee)
        {
            registrationFee = newFee;
            Console.WriteLine($"Registration fee updated to {registrationFee}");
        }
    }
}
