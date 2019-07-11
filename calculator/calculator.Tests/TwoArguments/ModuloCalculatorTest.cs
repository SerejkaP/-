using System;
using NUnit.Framework;

namespace calculator.Tests.TwoArguments
{
    [TestFixture]
    class ModuloCalculatorTest
    {
        [TestCase(0, 1, 0)]
        [TestCase(10, 9, 1)]
        [TestCase(-7, -2, -1)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new calculator.TwoArguments.ModuloCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void NegativeModuloCalculatorTest()
        {
            var calculator = new calculator.TwoArguments.ModuloCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(1, 0));
        }
    }
}
