using System;
using NUnit.Framework;
using Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Actual_Work;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Testing
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator Calc;

        [SetUp]
        public void Setup()
        {
            Calc = new Calculator();
        }

        [Test]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            int Result = Calc.Add(5, 3);
            Assert.That(Result, Is.EqualTo(8));
        }

        [Test]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            int Result = Calc.Subtract(10, 4);
            Assert.That(Result, Is.EqualTo(6));
        }

        [Test]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            int Result = Calc.Multiply(6, 7);
            Assert.That(Result, Is.EqualTo(42));
        }

        [Test]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            int Result = Calc.Divide(20, 4);
            Assert.That(Result, Is.EqualTo(5));
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.That(() => Calc.Divide(10, 0), Throws.TypeOf<DivideByZeroException>());
        }
    }
}
