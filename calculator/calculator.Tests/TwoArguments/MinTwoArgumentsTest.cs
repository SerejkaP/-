using calculator.TwoArguments;
using NUnit.Framework;

namespace calculator.Tests.TwoArguments
{
    [TestFixture]
    class MinTwoArgumentsTest
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 3)]
        [TestCase(-7, -2, -7)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new MinTwoArguments();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
