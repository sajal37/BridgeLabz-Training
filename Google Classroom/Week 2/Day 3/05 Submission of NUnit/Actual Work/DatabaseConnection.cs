using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Actual_Work
{
    public class DatabaseConnection
    {
        private bool Connected;

        public bool IsConnected
        {
            get { return Connected; }
        }

        public void Connect()
        {
            Connected = true;
            Console.WriteLine("Database connected");
        }

        public void Disconnect()
        {
            Connected = false;
            Console.WriteLine("Database disconnected");
        }
    }
}
