using NUnit.Framework;


namespace calculator.Tests.TwoArguments
{
    [TestFixture]
    class PowerTwoArgumentsTest
    {
        [TestCase(2, 2, 4)]
        [TestCase(3, 5, 243)]
        [TestCase(5, 2, 25)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new calculator.TwoArguments.PowerTwoArguments();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
