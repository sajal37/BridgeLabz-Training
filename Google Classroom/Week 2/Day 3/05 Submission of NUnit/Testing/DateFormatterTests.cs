using System;
using NUnit.Framework;
using Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Actual_Work;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Testing
{
    [TestFixture]
    public class DateFormatterTests
    {
        private DateFormatter Formatter;

        [SetUp]
        public void Setup()
        {
            Formatter = new DateFormatter();
        }

        [Test]
        public void FormatDate_ValidDate_ReturnsFormattedDate()
        {
            string Result = Formatter.FormatDate("2024-01-15");
            Assert.That(Result, Is.EqualTo("15-01-2024"));
        }

        [Test]
        public void FormatDate_AnotherValidDate_ReturnsFormattedDate()
        {
            string Result = Formatter.FormatDate("2023-12-25");
            Assert.That(Result, Is.EqualTo("25-12-2023"));
        }

        [Test]
        public void FormatDate_InvalidFormat_ThrowsArgumentException()
        {
            Assert.That(() => Formatter.FormatDate("15-01-2024"), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void FormatDate_InvalidDate_ThrowsArgumentException()
        {
            Assert.That(() => Formatter.FormatDate("2024-13-45"), Throws.TypeOf<ArgumentException>());
        }
    }
}
