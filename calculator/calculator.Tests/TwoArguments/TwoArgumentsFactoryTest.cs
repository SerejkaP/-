using calculator.TwoArguments;
using NUnit.Framework;
using System;

namespace calculator.Tests.TwoArguments
{
    [TestFixture]
    class TwoArgumentsFactoryTest
    {
        [TestCase("Division", typeof(DivideCalculator))]
        [TestCase("Plus", typeof(AdditionCalculator))]
        [TestCase("Average", typeof(Average))]
        [TestCase("Divide", typeof(DivisionCalculator))]
        [TestCase("Geometric", typeof(GeometricMean))]
        [TestCase("logTwoArguments", typeof(LogTwoArguments))]
        [TestCase("MAX", typeof(MaxTwoArguments))]
        [TestCase("MIN", typeof(MinTwoArguments))]
        [TestCase("Modulo", typeof(ModuloCalculator))]
        [TestCase("Multiply", typeof(MultiplyCalculator))]
        [TestCase("PowerOfDivision", typeof(PowerOfDivision))]
        [TestCase("PowerTwoArguments", typeof(PowerTwoArguments))]
        [TestCase("Minus", typeof(SubtractionCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }

    }
}
