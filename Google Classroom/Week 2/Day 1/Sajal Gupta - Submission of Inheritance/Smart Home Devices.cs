using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_1.Sajal_Gupta___Submission_of_Inheritance
{
    internal class Smart_Home_Devices
    {
        public void Demo()
        {
            Thermostat t1 = new Thermostat("TH001", "Active", 22.5);
            Thermostat t2 = new Thermostat("TH002", "Inactive", 18.0);

            t1.DisplayStatus();
            t2.DisplayStatus();
        }
    }

    class Device
    {
        protected string DeviceId;
        protected string Status;

        public Device (string deviceId, string status)
        {
            this.DeviceId = deviceId;
            this.Status = status;
        }

        public virtual void DisplayStatus()
        {
            Console.WriteLine($"Device ID: {DeviceId}, Status: {Status}");
        }
    }

    class Thermostat : Device
    {
        private double TemperatureSetting;

        public Thermostat (string deviceId, string status, double temp) : base(deviceId, status)
        {
            this.TemperatureSetting = temp;
        }

        public override void DisplayStatus()
        {
            Console.WriteLine($"Thermostat ID: {DeviceId}, Status: {Status}, Temperature: {TemperatureSetting}°C");
        }
    }
}
