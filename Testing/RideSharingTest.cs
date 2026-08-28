using System;
using System.Collections.Generic;
using System.Text;
using Ride_Sharing;

namespace Testing
{
    internal class RideSharingTest
    {
        [Test]
        public void Driver()
        {
            Driver d = new Driver("Rahul", 11, 23, 1, "Rajpura", "Ready");
            Assert.That(d.id, Is.EqualTo(11));
            Assert.That(d.age, Is.EqualTo(23));
        }
        [Test]
        public void Rider()
        {
            Rider r = new Rider("Vedant", 101, 20, "Waiting");
            Assert.That(r.id, Is.EqualTo(101));
            Assert.That(r.age, Is.EqualTo(20));
        }
        [Test]
        public void RideRequest()
        {
            RideRequest rq = new RideRequest(1, 29, 203, "Booked");
            Assert.That(rq.status, Is.EqualTo("Booked"));
        }
        [Test]
        public void RideRequestQueue()
        {
            Ride_Request_Queue queue = new Ride_Request_Queue();
            RideRequest request1 = new RideRequest(1, 11, 101, "Pending");
            RideRequest request2 = new RideRequest(2, 12, 102, "Pending");
            queue.Add(request1);
            queue.Add(request2);
            RideRequest result = queue.GetNext();
            Assert.That(result, Is.SameAs(request1));
            Assert.That(queue.Count(), Is.EqualTo(1));
        }
        [Test]
        public void EmptyQueue()
        {
            Ride_Request_Queue queue = new Ride_Request_Queue();
            Assert.That(queue.Count(), Is.EqualTo(0));
        }
        [Test]
        public void StackCount()
        {
            Cancellation c = new Cancellation();
            RideRequest req = new RideRequest(1, 11, 101, "Waiting");
            c.Add(req);
            int result = c.Count();
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void StackUndo()
        {
            Cancellation c = new Cancellation();
            RideRequest req = new RideRequest(1, 11, 101, "Waiting");
            c.Add(req);
            c.Undo();
            int result = c.Count();
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void LookupDriver()
        {
            Lookup lookup = new Lookup();
            Driver d = new Driver("Rahul", 11, 23, 1, "Rajpura", "Ready");
            lookup.AddDriver(d);
            Driver result = lookup.GetDriver(11);
            Assert.That(result, Is.SameAs(d));
        }
        [Test]
        public void LookupInvalid()
        {
            Lookup lookup = new Lookup();
            Driver result = lookup.GetDriver(999);
            Assert.That(result, Is.Null);
        }
        [Test]
        public void SortTest()
        {
            Sort sort = new Sort();
            Driver d1 = new Driver("Rahul", 11, 23, 1, "Rajpura", "Ready");
            Driver d2 = new Driver("Ved", 12, 26, 1, "Jhansla", "Ready");
            Driver d3 = new Driver("Saksham", 13, 24, 1, "Rajpura", "Ready");
            List<Driver> drivers = new List<Driver> { d1, d2, d3 };
            sort.SortByID(drivers);
            Assert.That(drivers[0].id, Is.EqualTo(11));
            Assert.That(drivers[1].id, Is.EqualTo(12));
            Assert.That(drivers[2].id, Is.EqualTo(13));
        }
    }
}
