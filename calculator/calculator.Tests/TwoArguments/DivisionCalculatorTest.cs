using NUnit.Framework;

namespace calculator.Tests.TwoArguments
{
    [TestFixture]
        public class DivisionCalculatorTests
        {
            [Test]
            public void DivisionCalculatorTest()
            {
                var calculator = new calculator.TwoArguments.DivisionCalculator();
                double actual = calculator.Calculate(2, 1);
                Assert.AreEqual(2, actual);
            }

        }
}
