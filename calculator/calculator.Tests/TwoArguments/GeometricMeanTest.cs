using NUnit.Framework;

namespace calculator.Tests.TwoArguments
{
    [TestFixture]
    class GeometricMeanTest
    {
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(2, 2, 2)]
        public void CalculateTest(
double firstValue,
double secondValue,
double expected)
        {
            var calculator = new calculator.TwoArguments.MinTwoArguments();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
