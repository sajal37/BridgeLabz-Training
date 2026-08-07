using System;
using NUnit.Framework;
using Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Actual_Work;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Testing
{
    [TestFixture]
    public class TemperatureConverterTests
    {
        private TemperatureConverter Converter;

        [SetUp]
        public void Setup()
        {
            Converter = new TemperatureConverter();
        }

        [Test]
        public void CelsiusToFahrenheit_ZeroCelsius_Returns32()
        {
            double Result = Converter.CelsiusToFahrenheit(0);
            Assert.That(Result, Is.EqualTo(32));
        }

        [Test]
        public void CelsiusToFahrenheit_100Celsius_Returns212()
        {
            double Result = Converter.CelsiusToFahrenheit(100);
            Assert.That(Result, Is.EqualTo(212));
        }

        [Test]
        public void FahrenheitToCelsius_32Fahrenheit_ReturnsZero()
        {
            double Result = Converter.FahrenheitToCelsius(32);
            Assert.That(Result, Is.EqualTo(0).Within(0.01));
        }

        [Test]
        public void FahrenheitToCelsius_212Fahrenheit_Returns100()
        {
            double Result = Converter.FahrenheitToCelsius(212);
            Assert.That(Result, Is.EqualTo(100).Within(0.01));
        }
    }
}
