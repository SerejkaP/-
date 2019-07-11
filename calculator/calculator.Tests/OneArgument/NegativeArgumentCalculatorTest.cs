using calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]
    class NegativeArgumentCalculatorTest
    {
        [TestCase(0, 0)]
        [TestCase(10, -10)]
        [TestCase(-7, 7)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new NegativeArgumentCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
