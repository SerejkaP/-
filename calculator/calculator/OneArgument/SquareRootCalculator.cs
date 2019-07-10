using System;

namespace calculator.OneArgument
{
    class SquareRootCalculator: IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Sqrt(firstValue);
        }
    }
}
