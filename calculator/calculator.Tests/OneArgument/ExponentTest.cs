using calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]
    class ExponentTest
    {
        [TestCase(0, 1)]
        [TestCase(-1, 0.367)]
        [TestCase(1, 2.718)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Exponent();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}
