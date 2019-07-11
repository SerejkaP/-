using calculator.OneArgument;
using NUnit.Framework;


namespace calculator.Tests.OneArgument
{
    [TestFixture]
    class CosinusCalculatorTest
    {
        [TestCase(0, 1)]
        [TestCase(1, 0.54)]
        [TestCase(2, -0.41)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new CosinusCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
