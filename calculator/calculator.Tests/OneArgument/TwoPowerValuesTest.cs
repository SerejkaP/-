using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]
    class TwoPowerValuesTest
    {
        [TestCase(0, 1)]
        [TestCase(2, 4)]
        [TestCase(-1, 0.5)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new calculator.OneArgument.TwoPowerValues();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
