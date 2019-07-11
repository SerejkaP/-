using System;
using NUnit.Framework;


namespace calculator.Tests.TwoArguments
{
    [TestFixture]
    class LogTwoArgumentsTest
    {
        [TestCase(2, 2, 1)]
        [TestCase(10, 100, 0.5)]
        [TestCase(4, 2, 2)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new calculator.TwoArguments.LogTwoArguments();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void NegativeLogTwoArgumentsForFirstArgumentTest()
        {
            var calculator = new calculator.TwoArguments.LogTwoArguments();
            Assert.Throws<Exception>(() => calculator.Calculate(-1, 1));
        }

        [Test]
        public void NegativeLogTwoArgumentsForSecondArgumentTest()
        {
            var calculator = new calculator.TwoArguments.LogTwoArguments();
            Assert.Throws<Exception>(() => calculator.Calculate(2, -1));
        }
    }
}
