using System;
using System.Collections.Generic;
using System.Text;
using Actual_Work;

namespace Testing
{
    public class StringUtilsTest
    {
        [Test]
        public void ReverseString()
        {
            StringUtils s = new StringUtils();
            string result = s.Reverse("Chitkara");
            Assert.That(result, Is.EqualTo("araktihC"));
        }
    }
}
