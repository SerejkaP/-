using NUnit.Framework;

namespace calculator.Tests.TwoArguments
{
    [TestFixture]
    class DivideCalculatorTest
    {
        [TestCase(4, 3, 1)]
        [TestCase(5, 2, 2)]
        [TestCase(-7, -3, 2)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new calculator.TwoArguments.DivideCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
