using NUnit.Framework;


namespace calculator.Tests.TwoArguments
{
    [TestFixture]
    class LogTwoArgumentsTest
    {
        [TestCase(1, 2, 0)]
        [TestCase(10, 100, 0.5)]
        [TestCase(4, 2, 2)]
        public void CalculateTest(
double firstValue,
double secondValue,
double expected)
        {
            var calculator = new calculator.TwoArguments.LogTwoArguments();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
