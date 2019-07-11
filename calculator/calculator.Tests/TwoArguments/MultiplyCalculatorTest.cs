using calculator.TwoArguments;
using NUnit.Framework;

namespace calculator.Tests.TwoArguments
{
    [TestFixture]
    public class MultiplyCalculatorTests
    {
        [Test]
        public void MultiplyCalculatorTest()
        {
            var calculator = new MultiplyCalculator();
            double actual = calculator.Calculate(2, 1);
            Assert.AreEqual(2, actual);
        }

    }

}
