using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace calculator.Tests.TwoArguments
{
    [TestFixture]
    public class AdditionCalculatorTests
    {
        [Test]
        public void AdditionCalculatorTest()
        {
            var calculator = new calculator.TwoArguments.AdditionCalculator();
            double actual = calculator.Calculate(1, 2);
            Assert.AreEqual(3, actual);
        }
        
    }

}
