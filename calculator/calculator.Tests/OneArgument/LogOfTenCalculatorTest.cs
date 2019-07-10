using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]
    class LogOgTenCalculatorTest
    {
        [TestCase(10, 1)]
        [TestCase(100, 2)]
        [TestCase(1, 0)]
        public void CalculateTest(
double firstValue,
double expected)
        {
            var calculator = new calculator.OneArgument.LogOfTenCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
