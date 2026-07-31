using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_7._02_Java_Constructors__Instance_vs._Class_Variables__Access_Modifiers_Level_1_Lab_Practice
{
    internal class Vehicle_Registration
    {
        public static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle("Rahul", "Car");
            Vehicle v2 = new Vehicle("Priya", "Bike");
            v1.Display();
            v2.Display();
            Vehicle.UpdateRegistrationFee(2000);
            v1.Display();
        }
    }
    class Vehicle
    {
        private string ownerName;
        private string vehicleType;
        public static double registrationFee = 1500;
        public Vehicle (string ownerName, string vehicleType)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }
        public void Display()
        {
            Console.WriteLine($"Owner {ownerName} has a {vehicleType} with registration fee {registrationFee}");
        }
        public static void UpdateRegistrationFee(double newFee)
        {
            registrationFee = newFee;
            Console.WriteLine($"Registration fee updated to {registrationFee}");
        }
    }
}
