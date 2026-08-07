using System;
using NUnit.Framework;
using Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Actual_Work;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Testing
{
    [TestFixture]
    public class UserRegistrationTests
    {
        private UserRegistration Registration;

        [SetUp]
        public void Setup()
        {
            Registration = new UserRegistration();
        }

        [Test]
        public void RegisterUser_ValidInputs_ReturnsTrue()
        {
            bool Result = Registration.RegisterUser("john_doe", "john@example.com", "password123");
            Assert.That(Result, Is.True);
        }

        [Test]
        public void RegisterUser_EmptyUsername_ThrowsArgumentException()
        {
            Assert.That(() => Registration.RegisterUser("", "john@example.com", "password123"), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void RegisterUser_InvalidEmail_ThrowsArgumentException()
        {
            Assert.That(() => Registration.RegisterUser("john_doe", "invalidemail", "password123"), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void RegisterUser_ShortPassword_ThrowsArgumentException()
        {
            Assert.That(() => Registration.RegisterUser("john_doe", "john@example.com", "pass"), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void RegisterUser_NullUsername_ThrowsArgumentException()
        {
            Assert.That(() => Registration.RegisterUser(null, "john@example.com", "password123"), Throws.TypeOf<ArgumentException>());
        }
    }
}
