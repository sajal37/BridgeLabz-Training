using System;
using System.Collections.Generic;
using System.Text;

namespace Ride_Sharing
{
    public class Trip_History
    {
        TripNode head;
        TripNode tail;
        public void Add(RideRequest req)
        {
            TripNode node = new TripNode(req);

            if (head == null)
            {
                head = tail = node;
            }
            else
            {
                tail.Next = node;
                node.Previous = tail;
                tail = node;
            }
        }
    }
    public class TripNode
    {
        public RideRequest req;
        public TripNode Next;
        public TripNode Previous;
        public TripNode(RideRequest req)
        {
            req = req;
        }
    }
}
