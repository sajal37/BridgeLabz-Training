using System;
using System.Collections.Generic;
using System.Text;

namespace Ride_Sharing
{
    public class Sort
    {
        public void SortByID(List<Driver> drivers)
        {
            drivers.Sort((a, b) => a.id.CompareTo(b.id));
        }
        public void SortByAge(List<Driver> drivers)
        {
            drivers.Sort((a, b) => a.age.CompareTo(b.age));
        }
    }
}
