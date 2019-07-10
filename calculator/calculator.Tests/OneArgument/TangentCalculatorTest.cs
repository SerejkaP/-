using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]
    class TangentCalculatorTest
    {
        [TestCase(0, 0)]
        [TestCase(1, 1.557)]
        [TestCase(-1, -1.557)]
        public void CalculateTest(
double firstValue,
double expected)
        {
            var calculator = new calculator.OneArgument.TangentCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}
