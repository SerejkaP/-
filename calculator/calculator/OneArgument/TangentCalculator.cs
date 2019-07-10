using System;

namespace calculator.OneArgument
{
    class TangentCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Tan(firstValue);
        }
    }
}
