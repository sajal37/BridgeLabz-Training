using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Ride_Sharing
{
    public class Ride_Request_Queue
    {
        Queue<RideRequest> q = new Queue<RideRequest>();
        public void Add(RideRequest req)
        {
            q.Enqueue(req);
        }
        public RideRequest GetNext()
        {
            return q.Dequeue();
        }
        public int Count()
        {
            return q.Count;
        }
    }
}
