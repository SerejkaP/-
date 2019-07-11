using calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]
    public class PowerCalculatorTests
    {
        [Test]
        public void PowerCalculatorTest()
        {
            var calculator = new PowerCalculator();
            double actual = calculator.Calculate(2);
            Assert.AreEqual(4, actual);
        }

    }
}
