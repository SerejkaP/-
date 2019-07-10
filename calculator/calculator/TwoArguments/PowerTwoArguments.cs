using System;

namespace calculator.TwoArguments
{
    class PowerTwoArguments : ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue,secondValue); 
        }
    }
}
