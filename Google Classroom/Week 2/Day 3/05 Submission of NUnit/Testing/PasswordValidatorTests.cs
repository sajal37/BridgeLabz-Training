using System;
using NUnit.Framework;
using Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Actual_Work;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Testing
{
    [TestFixture]
    public class PasswordValidatorTests
    {
        private PasswordValidator Validator;

        [SetUp]
        public void Setup()
        {
            Validator = new PasswordValidator();
        }

        [Test]
        public void IsValid_ValidPassword_ReturnsTrue()
        {
            bool Result = Validator.IsValid("Password1");
            Assert.That(Result, Is.True);
        }

        [Test]
        public void IsValid_TooShort_ReturnsFalse()
        {
            bool Result = Validator.IsValid("Pass1");
            Assert.That(Result, Is.False);
        }

        [Test]
        public void IsValid_NoUppercase_ReturnsFalse()
        {
            bool Result = Validator.IsValid("password1");
            Assert.That(Result, Is.False);
        }

        [Test]
        public void IsValid_NoDigit_ReturnsFalse()
        {
            bool Result = Validator.IsValid("Password");
            Assert.That(Result, Is.False);
        }

        [Test]
        public void IsValid_NullPassword_ReturnsFalse()
        {
            bool Result = Validator.IsValid(null);
            Assert.That(Result, Is.False);
        }
    }
}
