using System;
using System.Collections.Generic;
using System.Text;
using Actual_Work;

namespace Testing
{
    internal class TicketPoolTest
    {
        TicketPool<int> tp;
        [SetUp] 
        public void Setup()
        {
            tp = new TicketPool<int>();
        }
        [TearDown]

        [Test]
        public void ticketValidate()
        {
            bool result = tp.validate("TKT-AFFB0553", "Concert", 23, "sold");
            Assert.That(result, Is.True);
        }
        [Test]
        public void booking()
        {
            tp.validate("TKT-AFFB0553", "Concert", 23, "sold");
            int num = tp.numberOfTickets();
            Assert.That(1, Is.EqualTo(num));
        }
        [Test]
        public void removeTest()
        {
            tp.validate("TKT-AFFB0553", "Concert", 23, "sold");
            tp.remove();
            int num1 = tp.numberOfTickets();
            Assert.That(0, Is.EqualTo(num1));
        }
    }
}
