using System;

namespace calculator.OneArgument
{
    public class TangentCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Tan(firstValue);
        }
    }
}
