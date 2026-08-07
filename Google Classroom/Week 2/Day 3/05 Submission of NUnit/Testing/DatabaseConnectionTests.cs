using System;
using NUnit.Framework;
using Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Actual_Work;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Testing
{
    [TestFixture]
    public class DatabaseConnectionTests
    {
        private DatabaseConnection DB;

        [SetUp]
        public void Setup()
        {
            DB = new DatabaseConnection();
            DB.Connect();
        }

        [TearDown]
        public void TearDown()
        {
            DB.Disconnect();
        }

        [Test]
        public void Connect_EstablishesConnection_IsConnectedTrue()
        {
            bool Connected = DB.IsConnected;
            Assert.That(Connected, Is.True);
        }

        [Test]
        public void Disconnect_ClosesConnection_IsConnectedFalse()
        {
            DB.Disconnect();
            bool Connected = DB.IsConnected;
            Assert.That(Connected, Is.False);
        }
    }
}
