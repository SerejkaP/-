using NUnit.Framework;

namespace calculator.Tests.TwoArguments
{
    [TestFixture]
    class PowerOfDivisionTest
    {
        [TestCase(0, 0, 0)]
        [TestCase(1, 2, 1)]
        [TestCase(4, 2, 2)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new calculator.TwoArguments.PowerOfDivision();
            var actualResult = calculator.Calculate(firstValue,secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
