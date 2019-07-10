using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace calculator.Tests.TwoArguments
{
    [TestFixture]
    public class MultiplyCalculatorTests
    {
        [Test]
        public void MultiplyCalculatorTest()
        {
            var calculator = new calculator.TwoArguments.MultiplyCalculator();
            double actual = calculator.Calculate(2, 1);
            Assert.AreEqual(2, actual);
        }

    }

}
