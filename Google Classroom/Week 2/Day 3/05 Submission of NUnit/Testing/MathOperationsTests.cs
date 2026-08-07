using System;
using NUnit.Framework;
using Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Actual_Work;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Testing
{
    [TestFixture]
    public class MathOperationsTests
    {
        private MathOperations Math;

        [SetUp]
        public void Setup()
        {
            Math = new MathOperations();
        }

        [Test]
        public void Divide_ByZero_ThrowsArithmeticException()
        {
            Assert.That(() => Math.Divide(10, 0), Throws.TypeOf<ArithmeticException>());
        }

        [TestCase(2, ExpectedResult = true)]
        [TestCase(4, ExpectedResult = true)]
        [TestCase(6, ExpectedResult = true)]
        [TestCase(7, ExpectedResult = false)]
        [TestCase(9, ExpectedResult = false)]
        public bool IsEven_VariousNumbers_ReturnsCorrectResult(int number)
        {
            bool Result = Math.IsEven(number);
            return Result;
        }

        [Test]
        [Timeout(2000)]
        public void LongRunningTask_ExceedsTimeout_FailsTest()
        {
            string Result = Math.LongRunningTask();
            Assert.That(Result, Is.EqualTo("Task Completed"));
        }
    }
}
