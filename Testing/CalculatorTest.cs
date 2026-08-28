using Actual_Work;

namespace Testing
{
    public class CalculatorTest
    {
        Calculator c;
        [SetUp]
        public void Setup()
        {
            c = new Calculator();
        }
        [Test]
        public void AddNumbers()
        {
            Calculator c = new Calculator();
            int result = c.Add(10, 20);
            Assert.That(result, Is.EqualTo(30));
        }
        [Test]
        public void SubtractNumbers()
        {
            int result = c.Subtract(7, 5);
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void MultiplyNumbers()
        {
            int result = c.Multiply(4,5);
            Assert.That(result, Is.EqualTo(20));
        }
        [Test]
        public void DivideNumbers()
        {
            int result = c.Divide(60, 12);
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void DivideNumbers_Exception()
        {
            Assert.Throws<DivideByZeroException>(() => c.Divide(5, 0));
        }
    }
}
