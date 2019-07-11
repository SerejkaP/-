using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]
    class DivisionByArgumentCalculatorTest
    {
        [TestCase(1, 1)]
        [TestCase(2, 0.5)]
        [TestCase(-1, -1)]
        public void CalculateTest(
double firstValue,
double expected)
        {
            var calculator = new calculator.OneArgument.DivisionByArgumentCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
