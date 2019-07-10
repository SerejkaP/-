using System;

namespace calculator.OneArgument
{
    public class AbsoluteCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Abs(firstValue);
        }
    }
}
