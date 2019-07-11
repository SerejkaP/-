using calculator.OneArgument;
using NUnit.Framework;


namespace calculator.Tests.OneArgument
{
    [TestFixture]
    class SinusCalculatorTest
    {
        [TestCase(0, 0)]
        [TestCase(1, 0.841)]
        [TestCase(-1, -0.841)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new SinusCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}
