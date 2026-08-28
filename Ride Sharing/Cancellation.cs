using System;
using System.Collections.Generic;
using System.Text;

namespace Ride_Sharing
{
    public class Cancellation
    {
        Stack<RideRequest> st = new Stack<RideRequest>();
        public void Add(RideRequest req)
        {
            st.Push(req);
        }
        public void Undo()
        {
            st.Pop();
        }
        public int Count()
        {
            return st.Count();
        }
    }
}
