using System;

namespace calculator.OneArgument
{
    public class SquareRootCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Sqrt(firstValue);
        }
    }
}
