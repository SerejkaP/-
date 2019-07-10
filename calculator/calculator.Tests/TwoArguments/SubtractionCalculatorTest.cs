using NUnit.Framework;

namespace calculator.Tests.TwoArguments
{
    [TestFixture]
    public class SubtractionCalculatorTests
    {
        [Test]
        public void SubtractionCalculatorTest()
        {
            var calculator = new calculator.TwoArguments.SubtractionCalculator();
            double actual = calculator.Calculate(2, 1);
            Assert.AreEqual(1, actual);
        }

    }
}
