using System;
using System.Collections.Generic;
using System.Text;

namespace Ride_Sharing
{
    public class Lookup
    {
        Dictionary<int, Driver> d = new Dictionary<int, Driver>();
        Dictionary<int, Rider> r = new Dictionary<int, Rider>();
        public void AddDriver(Driver driver)
        {
            d[driver.id] = driver;
        }
        public void AddRider(Rider rider)
        {
            r[rider.id] = rider;
        }
        public Driver GetDriver(int id)
        {
            if (d.ContainsKey(id))
                return d[id];

            return null;
        }

        public Rider GetRider(int id)
        {
            if (r.ContainsKey(id))
                return r[id];

            return null;
        }
    }
}
