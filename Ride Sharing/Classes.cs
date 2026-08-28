using System;
using System.Collections.Generic;
using System.Text;

namespace Ride_Sharing
{
    public class Driver
    {
        public string name;
        public int id;
        public int age;
        public int zoneID;
        public string loc;
        public string status;
        public Driver(string name, int id, int age, int zoneID, string loc, string status)
        {
            this.name = name;
            this.id = id;
            this.age = age;
            this.zoneID = zoneID;
            this.loc = loc;
            this.status = status;
        }
    }
    public class Rider
    {
        public string name;
        public int id;
        public int age;
        public string status;
        public Rider(string name, int id, int age, string status)
        {
            this.name = name;
            this.id = id;
            this.age = age;
            this.status = status;
        }
    }
    public class RideRequest
    {
        public int id;
        public int DriverId;
        public int RiderId;
        public string status;
        public RideRequest(int id, int DriverId, int RiderId, string status)
        {
            this.id = id;
            this.DriverId = DriverId;
            this.RiderId = RiderId;
            this.status = status;
        }
    }
}
