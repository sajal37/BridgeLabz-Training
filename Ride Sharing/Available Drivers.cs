using System;
using System.Collections.Generic;
using System.Text;

namespace Ride_Sharing
{
    public class DriverNode
    {
        public Driver driver;
        public DriverNode Next;
        public DriverNode(Driver driver)
        {
            this.driver = driver;
        }
    }
    public class Available_Drivers
    {
        Driver d1 = new Driver("Rahul", 11, 23, 1, "Rajpura", "Ready");
        Driver d2 = new Driver("Ved", 12, 26, 1, "Jhansla", "Ready");
        Driver d3 = new Driver("Saksham", 13, 24, 1, "Rajpura", "Ready");
        DriverNode tail;
        public void AddDriver(Driver driver)
        {
            DriverNode node = new DriverNode(driver);
            if (tail == null)
            {
                tail = node;
                node.Next = node;
            }
            else
            {
                node.Next = tail.Next;
                tail.Next = node;
                tail = node;
            }
        }
    }

}
