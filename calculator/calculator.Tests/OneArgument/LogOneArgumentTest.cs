using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]
    class LogOneArgumentTest
    {
        [TestCase(1, 0)]
        [TestCase(2, 0.693)]
        [TestCase(3, 1.098)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new calculator.OneArgument.LogOneArgument();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult,0.001);
        }
    }
}
