using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.Tests.OneArgument
{
    [TestFixture]
    class AbsoluteCalculatorTest
    {
        [TestCase(0,0)]
        [TestCase(10,10)]
        [TestCase(-7,7)]
        public void CalculateTest(
double firstValue,
double expected)
        {
            var calculator = new calculator.OneArgument.AbsoluteCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
