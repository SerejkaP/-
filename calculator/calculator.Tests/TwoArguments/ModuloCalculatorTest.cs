using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.Tests.TwoArguments
{
    [TestFixture]
    class ModuloCalculatorTest
    {
        [TestCase(0, 1, 0)]
        [TestCase(10, 9, 1)]
        [TestCase(-7, -2, -1)]
        public void CalculateTest(
double firstValue,
double secondValue,
double expected)
        {
            var calculator = new calculator.TwoArguments.ModuloCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
