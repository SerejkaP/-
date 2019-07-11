using System;
using calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]
    class OneArgumentFactoryTest
    {
        [TestCase("Power", typeof(PowerCalculator))]
        [TestCase("SquareRoot", typeof(SquareRootCalculator))]
        [TestCase("Sinus", typeof(SinusCalculator))]
        [TestCase("Cosinus", typeof(CosinusCalculator))]
        [TestCase("LogOfExp", typeof(LogOneArgument))]
        [TestCase("Exponent", typeof(Exponent))]
        [TestCase("Tangent", typeof(TangentCalculator))]
        [TestCase("TwoPowerValues", typeof(TwoPowerValues))]
        [TestCase("Log10", typeof(LogOfTenCalculator))]
        [TestCase("Log2", typeof(LogOfTwoCalculator))]
        [TestCase("DivisionByArgument", typeof(DivisionByArgumentCalculator))]
        [TestCase("Absolute", typeof(AbsoluteCalculator))]
        [TestCase("Negative", typeof(NegativeArgumentCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
