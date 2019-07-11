using System;
using calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]
    public class SquareRootCalculatorTests
    {
        [Test]
        public void SquareRootCalculatorTest()
        {
            var calculator = new SquareRootCalculator();
            double actual = calculator.Calculate(4);
            Assert.AreEqual(2, actual);
        }

        [Test]
        public void NegativeSquareRootCalculatorTest()
        {
            var calculator = new SquareRootCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(-4));
        }
    }
} 
