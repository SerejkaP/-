using System;

namespace calculator.OneArgument
{
    class SinusCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Sin(firstValue);
        }
    }
}
