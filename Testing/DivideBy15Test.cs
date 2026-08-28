using System;
using System.Collections.Generic;
using System.Text;
using Actual_Work;

namespace Testing
{
    internal class DivideBy15Test
    {
        [Test]
        [TestCase(45, true)]
        [TestCase(0, true)]
        [TestCase(747, false)]
        [TestCase(-30, true)]
        [TestCase(-51, false)]
        public void Divisble15Test(int x, bool expected)
        {
            DivideBy15 d = new DivideBy15();
            bool result = d.IsDivideBy15(x);
            Assert.That(result, Is.EqualTo(expected));
        } 
    }
}
