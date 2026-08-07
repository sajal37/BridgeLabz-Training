using System;
using NUnit.Framework;
using Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Actual_Work;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Testing
{
    [TestFixture]
    public class StringUtilsTests
    {
        private StringUtils Utils;

        [SetUp]
        public void Setup()
        {
            Utils = new StringUtils();
        }

        [Test]
        public void Reverse_SimpleString_ReturnsReversed()
        {
            string Result = Utils.Reverse("hello");
            Assert.That(Result, Is.EqualTo("olleh"));
        }

        [Test]
        public void IsPalindrome_PalindromeString_ReturnsTrue()
        {
            bool Result = Utils.IsPalindrome("madam");
            Assert.That(Result, Is.True);
        }

        [Test]
        public void IsPalindrome_NonPalindromeString_ReturnsFalse()
        {
            bool Result = Utils.IsPalindrome("hello");
            Assert.That(Result, Is.False);
        }

        [Test]
        public void ToUpperCase_LowercaseString_ReturnsUppercase()
        {
            string Result = Utils.ToUpperCase("test");
            Assert.That(Result, Is.EqualTo("TEST"));
        }

        [Test]
        public void Reverse_NullString_ReturnsNull()
        {
            string Result = Utils.Reverse(null);
            Assert.That(Result, Is.Null);
        }
    }
}
