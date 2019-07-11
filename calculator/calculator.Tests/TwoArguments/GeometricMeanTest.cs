using System;
using calculator.TwoArguments;
using NUnit.Framework;

namespace calculator.Tests.TwoArguments
{
    [TestFixture]
    class GeometricMeanTest
    {
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(2, 2, 2)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new GeometricMean();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void NegativeGeometricMeanTest()
        {
            var calculator = new GeometricMean();
            Assert.Throws<Exception>(() => calculator.Calculate(-1, 1));
        }
    }
}
