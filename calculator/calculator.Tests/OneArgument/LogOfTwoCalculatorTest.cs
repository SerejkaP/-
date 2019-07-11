using System;
using NUnit.Framework;


namespace calculator.Tests.OneArgument
{
    [TestFixture]
    class LogOfTwoCalculatorTest
    {
        [TestCase(2, 1)]
        [TestCase(4, 2)]
        [TestCase(1, 0)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new calculator.OneArgument.LogOfTwoCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void NegativeLogOfTwoCalculatorTest()
        {
            var calculator = new calculator.OneArgument.LogOfTwoCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(-1));
        }
    }
}
