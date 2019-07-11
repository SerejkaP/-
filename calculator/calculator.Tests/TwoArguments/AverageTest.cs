using NUnit.Framework;

namespace calculator.Tests.TwoArguments
{
    [TestFixture]
    class AverageTest
    {
        [TestCase(0, 0, 0)]
        [TestCase(5, 3, 4)]
        [TestCase(-7, -3, -5)]
        public void CalculateTest(
double firstValue,
double secondValue,
double expected)
        {
            var calculator = new calculator.TwoArguments.Average();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
